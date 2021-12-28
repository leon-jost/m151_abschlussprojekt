using System.Net.Http.Json;

namespace M151AbschlussprojektFrontend.Services.TomTomApi
{
    public class TrafficIncidentService : ITrafficIncidentService
    {
        HttpClient _httpClient;
        IConfiguration _configuration;

        public TrafficIncidentService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Traffic?> GetTrafficIncidentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Traffic?>($"{_configuration["tomTomApi:baseUrl"]}/incidentDetails?key=CFSNkPl1ywmPJqNtxODTtiCO0SEcCAVn&bbox=8.627789,47.138083,8.93951,47.510497&fields={{incidents{{type,geometry{{type,coordinates}},properties{{id,iconCategory,magnitudeOfDelay,events{{description,code}},startTime,endTime,from,to,length,delay,roadNumbers,timeValidity,aci{{probabilityOfOccurrence,numberOfReports,lastReportTime}},tmc{{countryCode,tableNumber,tableVersion,direction,points{{location,offset}}}}}}}}}}&language=de-DE");
        }
    }
}
