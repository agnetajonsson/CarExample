namespace CarExample
{
    public interface IVehicle
    {
        string RegNo { get; set; }

        void Drive(double distanceKm);
    }
}