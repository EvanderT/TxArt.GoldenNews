namespace TxArt.GoldenNews.Web.Helpers
{
    public class FilesHelper
    {
        public static async Task<string> UploadFileAsync(IFormFile file, string folderPath, string fileName)
        {
            if (file == null || string.IsNullOrEmpty(folderPath) || string.IsNullOrEmpty(fileName))
            {
                return null;
            }

            try
            {
                // Verificar se o diretório de destino existe e criar, se necessário
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Construir o caminho completo do arquivo com o nome de arquivo fornecido
                string filePath = Path.Combine(folderPath, fileName);

                // Abrir um fluxo de arquivo para salvar o arquivo
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return filePath;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
