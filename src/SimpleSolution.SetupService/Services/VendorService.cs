using Microsoft.EntityFrameworkCore;
using SimpleSolution.SharedApi.Exceptions;

namespace SimpleSolution.SetupService.Services;
public class VendorService : IVendorService
{

}

public interface IVendorService
{

}

public abstract class BaseService
{
    public T ExecuteService<T>(Func<T> execute)
    {
        return Execute(execute);
    }

    public async Task<T> ExecuteServiceAsync<T>(Func<T> execute)
    {
        return await Task.Run(() =>
        {
            return Execute(execute);
        });
    }


    private static T Execute<T>(Func<T> execute)
    {
        try
        {
            return execute();
        }
        catch (DbUpdateException db)
        {
            throw new ApiException(db.Message)
            {
                //ErrorCode = ErrorCodes.DbError
            };
        }
        catch (OperationCanceledException op)
        {
            throw new ApiException(op.Message)
            {
                //ErrorCode = ErrorCodes.OperationCancelled
            };
        }
    }

}

