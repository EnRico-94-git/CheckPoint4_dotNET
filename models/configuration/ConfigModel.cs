namespace models.configuration
{
    public class ConfigModel
    {
        private static ConfigModel _instance;
        public string ApiKey { get; private set; }

        private ConfigModel()
        {
            // Carregar a chave de API de um arquivo de configuração, variáveis de ambiente, etc.
            ApiKey = "feb628771760a04e158f0340";
        }

        public static ConfigModel Instance => _instance ??= new ConfigModel();
    }
}
