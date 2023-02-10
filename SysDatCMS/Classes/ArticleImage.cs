using System.Drawing;
using System.IO;

namespace SysDatCMS.Classes
{
    public class ArticleImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public Image GraphicImage { get; set; }

        public ArticleImage(int id, string path, string name)
        {
            Id = id;
            Path = path;
            Name = name;

            using (FileStream stream = new FileStream(path + name, FileMode.Open))
            {
                GraphicImage = Image.FromStream(stream);
            }

            //TODO Da chiedere: Qual'e il metodo migliore?

            //using (var bmpTemp = new Bitmap(path + name))
            //{
            //    GraphicImage = new Bitmap(bmpTemp);
            //}

            //GraphicImage = Image.FromFile(path + name);
        }
    }
}
