using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentGenerator
{
    using System.Diagnostics;
    using System.Drawing;
    using Novacode;
    using Image = Novacode.Image;

    class WordDocumentGenerator
    {
        static void Main()
        {
            CreateDocument();
        }

        public static void CreateDocument()
        {
            // Modify to suit your machine:
            string fileName = @"../../DocXExample.docx";

            // Create a document in memory:
            var doc = DocX.Create(fileName);

            //title
            string titleText = "SoftUni OOP Game Contest";
            Paragraph title = doc.InsertParagraph(titleText);
            title.Font(new FontFamily("Arial"));
            title.Bold();
            title.FontSize(20);
            title.Color(Color.DarkViolet);
            title.Alignment = Alignment.center;
           
            //image
            Image image = doc.AddImage("../../rpg-game.png");
            Picture picture = image.CreatePicture(250, 600);
            Paragraph pic = doc.InsertParagraph("");
            pic.InsertPicture(picture);

            //content
            string contentText =
                "\n" + "SoftUni is organizing a contest for the best role playing game from the OOP teamwork projects. " +
                "The winning teams will receive a grand prize!" + "\n" + "The game should be:";
            Paragraph content = doc.InsertParagraph(contentText);
            title.Font(new FontFamily("Arial"));
            title.FontSize(10);
            title.Color(Color.Black);
            title.Alignment = Alignment.both;

            //list
            List list = doc.AddList(null, 0, ListItemType.Bulleted);
            doc.AddListItem(list, "Properly structured and follow all good OOP practices", 1);
            doc.AddListItem(list, "Awesome", 1);
            doc.AddListItem(list, "...Very Awesome", 1);
            doc.InsertList(list);

            doc.InsertParagraph("\r\n");

            //table
            Table table = doc.AddTable(4, 3);
            table.Alignment = Alignment.center;
            table.Rows[0].Cells[0].Paragraphs.First().Append("Team").Font(new FontFamily("Arial")).Bold().Color(Color.White).Alignment = Alignment.center;
            table.Rows[0].Cells[0].FillColor = Color.DarkViolet;
            table.Rows[0].Cells[1].Paragraphs.First().Append("Game").Font(new FontFamily("Arial")).Bold().Color(Color.White).Alignment = Alignment.center;
            table.Rows[0].Cells[1].FillColor = Color.DarkViolet;
            table.Rows[0].Cells[2].Paragraphs.First().Append("Points").Font(new FontFamily("Arial")).Bold().Color(Color.White).Alignment = Alignment.center;
            table.Rows[0].Cells[2].FillColor = Color.DarkViolet;
            table.Rows[0].Cells.ForEach(c => c.Width = 300);
            table.Rows[1].Cells.ForEach(c => c.Width = 300);
            table.Rows[2].Cells.ForEach(c => c.Width = 300);

            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table.Rows[i].Cells[j].Paragraphs.First().Append("-");
                    table.Rows[i].Cells[j].Paragraphs.First().Alignment = Alignment.center;
                }
            }
            doc.InsertTable(table);

            //foother
            string footherText =
                "\n" + "The top 3 teams will receive a SPECTACULAR prize:" + "\n" + "A HANDSHAKE FROM NAKOV";
            Paragraph foother = doc.InsertParagraph(footherText);
            title.Font(new FontFamily("Arial"));
            title.FontSize(10);
            title.Color(Color.Black);
            title.Alignment = Alignment.both;
            
            // Save to the output directory:
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
