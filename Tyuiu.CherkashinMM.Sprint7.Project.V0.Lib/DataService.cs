namespace Tyuiu.CherkashinMM.Sprint7.Project.V0.Lib
{
    public class DataService
    {
        public List<string[]> readTable(string path)
        {
            var rows = new List<string[]>();
            using (var reader = new StreamReader(path))
            {
                string line = reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    var columns = line.Split(';');
                    rows.Add(columns);
                }
            }
            return rows;
        }

        public void SaveToFile(string filePath, string[] columnNames, string[,] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(string.Join(";", columnNames));

                int rows = data.GetLength(0);
                int cols = data.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    List<string> rowData = new List<string>();
                    for (int j = 0; j < cols; j++)
                    {
                        rowData.Add(data[i, j] ?? string.Empty);
                    }

                    writer.WriteLine(string.Join(";", rowData));
                }
            }
        }
    }
}
