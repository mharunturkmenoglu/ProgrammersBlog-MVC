using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 286, DateTimeKind.Local).AddTicks(3934), "C# programlama dili ile ilgili en guncel Bilgiler", true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 286, DateTimeKind.Local).AddTicks(3949), "C#", "C# Blog Kategorisi" },
                    { 2, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 286, DateTimeKind.Local).AddTicks(3967), "C++ programlama dili ile ilgili en guncel Bilgiler", true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 286, DateTimeKind.Local).AddTicks(3969), "C++", "C++ Blog Kategorisi" },
                    { 3, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 286, DateTimeKind.Local).AddTicks(3973), "JavaScript programlama dili ile ilgili en guncel Bilgiler", true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 286, DateTimeKind.Local).AddTicks(3975), "JavaScript", "JavaScript Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 290, DateTimeKind.Local).AddTicks(9330), "Admin Rolu, Tum Haklara Sahiptir.", true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 290, DateTimeKind.Local).AddTicks(9344), "Admin", "Admins Role" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "Username" },
                values: new object[] { 1, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 303, DateTimeKind.Local).AddTicks(9520), "Ilk Admin Kullanici", "mht9811@gmail.com", "Harun", true, false, "Turkmenoglu", "Initial create", new DateTime(2021, 7, 4, 1, 39, 10, 303, DateTimeKind.Local).AddTicks(9535), "Admin kullanicisi", new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU", 1, "vrMHT" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedTime", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[] { 1, 1, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 282, DateTimeKind.Local).AddTicks(8766), new DateTime(2021, 7, 4, 1, 39, 10, 282, DateTimeKind.Local).AddTicks(7495), true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 282, DateTimeKind.Local).AddTicks(9428), "C# 9.0 ve .NET 5.0 Yenilikleri", "Harun Turkmenoglu", "C# 9.0 ve .NET 5.0 Yenilikleri", "C#, C# 9, .NET 5, .NET Core", "default.png", "C# 9.0 ve .NET 5.0 Yenilikleri", 1, 100 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedTime", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[] { 2, 2, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 283, DateTimeKind.Local).AddTicks(935), new DateTime(2021, 7, 4, 1, 39, 10, 283, DateTimeKind.Local).AddTicks(933), true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 283, DateTimeKind.Local).AddTicks(937), "C++ 11.0 ve Yenilikleri", "Harun Turkmenoglu", "C++ 11.0 ve Yenilikleri", "C++, C++ 11", "default.png", "C++ 9.0 ve .NET 5.0 Yenilikleri", 1, 50 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedTime", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[] { 3, 3, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 283, DateTimeKind.Local).AddTicks(944), new DateTime(2021, 7, 4, 1, 39, 10, 283, DateTimeKind.Local).AddTicks(943), true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 283, DateTimeKind.Local).AddTicks(946), "JavaScript ES2019 ve ES2020 Yenilikleri", "Harun Turkmenoglu", "JavaScript++ ES2019 ve ES2020 Yenilikleri", "JavaScript, JavaScript ES2019, JavaScript ES2020", "default.png", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 70 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 1, 1, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 289, DateTimeKind.Local).AddTicks(152), true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 289, DateTimeKind.Local).AddTicks(167), "C# makale yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır.Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir.Eğer bir Lorem Ipsum pasajı kullanacaksanız,metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir.İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır.Bu nedenle,üretilen Lorem Ipsum metinleri yinelemelerden,mizahtan ve karakteristik olmayan sözcüklerden uzaktır." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 2, 2, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 289, DateTimeKind.Local).AddTicks(188), true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 289, DateTimeKind.Local).AddTicks(189), "C++ makale yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır.Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir.Eğer bir Lorem Ipsum pasajı kullanacaksanız,metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir.İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır.Bu nedenle,üretilen Lorem Ipsum metinleri yinelemelerden,mizahtan ve karakteristik olmayan sözcüklerden uzaktır." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 3, 3, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 289, DateTimeKind.Local).AddTicks(194), true, false, "Initial Create", new DateTime(2021, 7, 4, 1, 39, 10, 289, DateTimeKind.Local).AddTicks(195), "C++ makale yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır.Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir.Eğer bir Lorem Ipsum pasajı kullanacaksanız,metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir.İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır.Bu nedenle,üretilen Lorem Ipsum metinleri yinelemelerden,mizahtan ve karakteristik olmayan sözcüklerden uzaktır." });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
