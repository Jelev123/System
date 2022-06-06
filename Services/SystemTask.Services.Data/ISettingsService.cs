namespace SystemTask.Services.Data
{
    using global::System.Collections.Generic;

    public interface ISettingsService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
