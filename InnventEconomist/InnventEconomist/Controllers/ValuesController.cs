namespace InnventEconnomics.Controllers
{
    using System.Web.Http;

    public class ValuesController : ApiController
    {
        public IHttpActionResult GetValues()
        {
            return Ok(new[] { "a", "b", "c" });
        }

        public IHttpActionResult GetValues(int id)
        {
            string[] nomes = new string[] { "ana", "ramon", "outros" };
            string nomeSelecionado = "nenhum";
            switch (id)
            {
                case 1:
                    nomeSelecionado = nomes[id - 1];
                    break;
                case 2:
                    nomeSelecionado = nomes[id - 1];
                    break;
                default:
                    nomeSelecionado = nomes[2];
                    break;

            }
            return Ok(nomeSelecionado);
        }
    }
}
