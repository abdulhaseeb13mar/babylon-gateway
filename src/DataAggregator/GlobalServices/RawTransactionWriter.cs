using Common.Database;
using Common.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAggregator.GlobalServices;

public interface IRawTransactionWriter
{
    Task EnsureRawTransactionsCreatedOrUpdated(List<RawTransaction> rawTransactions, CancellationToken token);
}

public class RawTransactionWriter : IRawTransactionWriter
{
    private readonly IDbContextFactory<CommonDbContext> _contextFactory;

    public RawTransactionWriter(IDbContextFactory<CommonDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task EnsureRawTransactionsCreatedOrUpdated(List<RawTransaction> rawTransactions, CancellationToken token)
    {
        await using var context = await _contextFactory.CreateDbContextAsync(token);

        // See https://github.com/artiomchi/FlexLabs.Upsert/wiki/Usage
        await context.RawTransactions
            .UpsertRange(rawTransactions)
            .WhenMatched((existingTransaction, newTransaction) => new RawTransaction
            {
                TransactionIdentifierHash = newTransaction.TransactionIdentifierHash,
                SubmittedTimestamp = newTransaction.SubmittedTimestamp ?? existingTransaction.SubmittedTimestamp,
                Payload = newTransaction.Payload ?? existingTransaction.Payload,
            })
            .RunAsync(token);

        await context.SaveChangesAsync(token);
    }
}