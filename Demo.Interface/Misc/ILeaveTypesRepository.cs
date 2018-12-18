namespace Hourly.Interface.Misc
{
    public interface ILeaveTypesRepository
    {
        ILeaveTypes GetLeaveTypes(int departmentId);
    }
}
