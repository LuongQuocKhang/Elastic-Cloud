using Elasticsearch.Net;
using Nest;

namespace VSS
{
    public static class ElasticClientFactory
    {
        public static ElasticClient Create()
        {
            BasicAuthenticationCredentials credentials = new BasicAuthenticationCredentials("elastic", "Xzy7g58AohUwjo6efwfE5sPz");
            CloudConnectionPool pool = new CloudConnectionPool(cloudId: "vss:d2VzdHVzMi5henVyZS5lbGFzdGljLWNsb3VkLmNvbTo0NDMkMjU4MTJhNTMyY2UyNDE1NmIxOTkwYWUwYmVlNmNiNGUkMjNhZDE5Nzk2ZGU4NGU2ZTgwODg0MWFiMzk5YjE2YWI=", credentials);
            ElasticClient client = new ElasticClient(new ConnectionSettings(pool));

            return client;
        }
    }
}
