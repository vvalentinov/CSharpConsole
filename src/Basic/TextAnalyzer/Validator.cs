namespace TextAnalyzer
{
    public static class Validator
    {
        public static (bool, string) IsFilePathValid(string filePath, string? allowedFileExtension = null)
        {
            if (File.Exists(filePath) == false)
            {
                return (false, "Look's like that directory doesn't exist. Try, again.");
            }

            if (allowedFileExtension != null && Path.GetExtension(filePath) != allowedFileExtension)
            {
                return (false, "Look's like the file you pointed is not a text file. Try, again.");
            }

            var fileInfo = new FileInfo(filePath);

            if (fileInfo.Length == 0)
            {
                return (false, "Look's like the file you pointed is an empty file. Try, again.");
            }

            return (true, string.Empty);
        }
    }
}
