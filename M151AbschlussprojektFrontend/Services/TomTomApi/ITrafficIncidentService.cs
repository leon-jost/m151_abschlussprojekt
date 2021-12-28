namespace M151AbschlussprojektFrontend.Services.TomTomApi
{
    public interface ITrafficIncidentService
    {
        public Task<Traffic?> GetTrafficIncidentsAsync();
    }
}
