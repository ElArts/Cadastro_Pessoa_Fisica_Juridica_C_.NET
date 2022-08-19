namespace CadastroPessoa.Classes 
{
    static class Utils
    {
        public static void VerificarPastaArquivo(string Caminho){

            string pasta = Caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(Caminho))
            {
                using (File.Create(Caminho)){}
            }
        }
    }
}