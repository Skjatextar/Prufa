using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using Prufa3.Models.Entity;

namespace Prufa3.App_Data.DataAccessLayer
{
    public class SubDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SubDataContext>
    {
        protected override void Seed(SubDataContext context)
        {
            var clients = new List<Client>
            {
                new Client
                {
                    sUsername = "Guffi",
                    sPass = "meistari",
                    sEmail = "guffi@ru.is",
                    iRanking = 1,
                    iTheme = 1,
                    dSignupDate = DateTime.Parse("07-05-2014")
                } //,
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment
                {
                    iCommentId = 1,
                    sCommenterUsername = "Mína",
                    sCommentText = "Geðveikt",
                    dCommentDate = DateTime.Parse("07-05-2014")
                }
            };

            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();

            var requests = new List<Request>
            {
                new Request
                {
                    sRequesterUsername = "Mikki",
                    sTitle = "The Rock",
                    sSubType = "Kvikmynd",
                    sLanguageFrom = "Enska",
                    sLanguageTo = "Íslenska",
                    sPicture = "Slóð að mynd",
                    iUpVote = 5,
                    sRequestDescription = "Verð að fá þýðingu á þessari",
                    dRequestDate = DateTime.Parse("07-05-2014")
                }
            };

            requests.ForEach(r => context.Requests.Add(r));
            context.SaveChanges();

            var subfiles = new List<SubFile>
            {
                new SubFile
                {
                    sTitle = "The Rock",
                    sFilePath = "Á tölvunni minni",
                    sPicture = "Slóð að mynd",
                    sGenre = "Spennumynd",
                    sSubType = "Kvikmynd",
                    sSubLanguage = "Enska",
                    sSubDescription = "Góðir strákar lenda í fangelsi",
                    iUpVote = 5,
                    dSubDate = DateTime.Parse("07-05-2014")
                }
            };

            subfiles.ForEach(s => context.SubFiles.Add(s));
            context.SaveChanges();
        }
    }
}