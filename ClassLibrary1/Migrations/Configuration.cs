namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary1.salesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClassLibrary1.salesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

           /* context.Members.AddOrUpdate(member => member.MemberId, new Member[] {
               new Member
               {
                   MemberId = 1,
                   FirstName = "Elizabeth",
                   SecondName= "Andersen"
               },
               new Member
               {
                   MemberId = 2,
                   FirstName = "Catherine",
                   SecondName= "Autier Miconi"
               },
               new Member
               {
                   MemberId = 3,
                   FirstName = "Thomas",
                   SecondName= "Axen"
               },
              new Member
               {
                   MemberId = 4,
                   FirstName = "Jean Philippe",
                   SecondName= "Bagel"
               },
               new Member
               {
                   MemberId = 5,
                   FirstName = "Anna",
                   SecondName= "Bedecs"
               },
            new Member
               {
                   MemberId = 6,
                   FirstName = "John",
                   SecondName= "Edwards"
               },
                  new Member
               {
                   MemberId = 7,
                   FirstName = "Alexander",
                   SecondName= "Eggerer"
               },
              new Member
               {
                   MemberId = 8,
                   FirstName = "Michael",
                   SecondName= "Entin"
               },
              new Member
               {
                   MemberId = 9,
                   FirstName = "Daniel",
                   SecondName= "Goldschmidt"
               },
               new Member
               {
                   MemberId = 10,
                   FirstName = "Antonio",
                   SecondName= "Gratacos Solsona"
               },
               new Member
               {
                   MemberId = 11,
                   FirstName = "Carlos",
                   SecondName= "Grilo"
               },
               new Member
               {
                   MemberId = 12,
                   FirstName = " Jonas",
                   SecondName= "Hasselberg"
               }
            });

            context.Books.AddOrUpdate(book => book.BookId, new Book[] {
               new Book
               {
                   BookId=1,
                   Title="The Hunger Games",
                   ISBN="9780439023481",
                   Author ="Suzanne Collins",
                   LoanDuration=28
               },
              new Book
               {
                   BookId=2,
                   Title="Nineteen Eighty-Four",
                   ISBN="1110141036141",
                   Author ="George Orwell",
                   LoanDuration=28
               },
               new Book
               {
                   BookId=3,
                   Title="Brave New World",
                   ISBN="2220060929871",
                   Author ="Aldous Huxley",
                   LoanDuration=1
               },

                new Book
               {
                   BookId=4,
                   Title="The Hound of the Baskervilles",
                   ISBN="0001234564389",
                   Author ="Athur Conan Doyle",
                   LoanDuration=28
               },
               new Book
               {
                   BookId=5,
                   Title="Literary works of Leonardo da Vinci",
                   ISBN="0123456789196",
                   Author ="Leonardo da Vinci",
                   LoanDuration=1
               },
               new Book
               {
                   BookId=6,
                   Title="The Arctic Incident",
                   ISBN="9780786851478",
                   Author ="Eoin Colfer",
                   LoanDuration=28
               },
               new Book
               {
                   BookId=7,
                   Title="Physical chemistry",
                   ISBN="0716720736",
                   Author="P. W. Atkins",
                   LoanDuration=1
               },
               new Book
               {
                   BookId=8,
                   Title="Universe",
                   ISBN="0716746476",
                   Author="Roger Freedman",
                   LoanDuration=28
               },

            });
            context.Loans.AddOrUpdate(loan => loan.MemberId, new Loan[] {
               new Loan
               {
                   LoanId=1,
                   MemberId=1,
                   BookId=1,
                   LoanIssueDate = DateTime.Parse("05/12/2019")
               },
               new Loan
               {
                   LoanId=2,
                   MemberId=1,
                   BookId=2,
                   LoanIssueDate = DateTime.Parse("17/10/2019")
               },
               new Loan
               {
                   LoanId=3,
                   MemberId=5,
                   BookId=3,
                   LoanIssueDate = DateTime.Parse("12/12/2019")
               },
               new Loan
               {
                   LoanId=4,
                   MemberId=8,
                   BookId=7,
                   LoanIssueDate = DateTime.Parse("23/11/2019")
               },
               new Loan
               {
                   LoanId=5,
                   MemberId=6,
                   BookId=4,
                   LoanIssueDate = DateTime.Parse("21/10/2019")
               },
            }); */
        }
    }
}
