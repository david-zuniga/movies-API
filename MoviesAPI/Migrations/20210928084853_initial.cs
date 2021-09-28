using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoviesActors",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesActors", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MoviesActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviesGenders",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesGenders", x => new { x.MovieId, x.GenderId });
                    table.ForeignKey(
                        name: "FK_MoviesGenders_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesGenders_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesActors_ActorId",
                table: "MoviesActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesGenders_GenderId",
                table: "MoviesGenders",
                column: "GenderId");

            migrationBuilder.Sql(@"                

                    USE [MoviesApp]
                    GO

                    INSERT INTO Genders VALUES 
                    ('Science Fiction'), 
                    ('Super Hero'),
                    ('Action Adventure'),
                    ('Fantasy'),
                    ('Comedy'),
                    ('Spy')

                    GO

                    INSERT INTO Actors VALUES
                    ('Paul Rudd'),
                    ('Evangeline Lilly'),
                    ('Corey Stoll'),

                    ('Michael Peña'),

                    ('Robert Downey Jr.'),
                    ('Chris Evans'),
                    ('Mark Ruffalo'),
                    ('Chris Hemsworth'),
                    ('Scarlett Johansson'),

                    ('Chadwick Boseman'),
                    ('Michael B. Jordan'),
                    ('Lupita Nyong'),

                    ('Brie Larson'),
                    ('Samuel L. Jackson'),

                    ('Benedict Cumberbatch'),
                    ('Chiwetel Ejiofor'),
                    ('Rachel McAdams'),

                    ('Chris Pratt'),
                    ('Zoe Saldama'),
                    ('Dave Bautista'),
                    ('Vin Diesel'),
                    ('Bradley Cooper'),
                    ('Lee Pace'),

                    ('Gwyneth Paltrow'),
                    ('Don Cheadle'),
                    ('Guy Pearce'),

                    ('Florence Pugh'),
                    ('David Harbour'),
                    ('O-T Fagbenle'),

                    ('Tommy Lee Jones'),
                    ('Hugo Weaving'),
                    ('Hayley Atwell'),

                    ('Natalie Portman'),
                    ('Tom Hiddleston'),

                    ('Sebastian Stan'),
                    ('Anthony Mackie'),
                    ('Cobie Smulders')

                    GO

                    INSERT INTO Movies VALUES
                    ('Antman', 'antman.jpg', '1h 59m', '2015'),
                    ('Antman and the Wasp', 'antman-and-wasp.jpg', '2h', '2018'),
                    ('Avengers', 'avengers.jpg', '2h 25m', '2012'),
                    ('Avengers Age of Ultron', 'avengers-age-of-ultron.jpg', '2h 23m', '2015'),
                    ('Avengers Endgame', 'avengers-endgame.jpg', '3h 4m', '2019'),
                    ('Avengers Infinity War', 'avengers-infinity-war.jpg', '2h 32m', '2018'),
                    ('Black Panther', 'black-panther.jpg', '2h 17m', '2018'),
                    ('Captain Marvel', 'captain-marvel.jpg', '2h 5m', '2019'),
                    ('Civil War', 'civil-war.jpg', '2h 30m', '2016'),
                    ('Doctor Strange', 'doctor-strange.jpg', '1h 56m', '2016'),
                    ('Guardians of the Galaxy', 'guardians-of-the-galaxy.jpg', '2h 2m', '2014'),
                    ('Guardians of the Galaxy 2', 'guardians-of-the-galaxy-2.jpg', '2h 17m', '2017'),
                    ('Iron Man 3', 'iron-man-3.jpg', '2h 12m', '2013'),
                    ('The Black Widow', 'the-black-widow.jpg', '2h 15m', '2021'),
                    ('The first Avenger', 'the-first-avenger.jpg', '2h 6m', '2011'),
                    ('Thor Ragnarok', 'thor-ragnarok.jpg', '2h 11m', '2017'),
                    ('Thor the Dark World', 'thor-the-dark-world.jpg', '1h 54m', '2013'),
                    ('The Winter Soldier', 'winter-soldier.jpg', '2h 18m', '2014')

                    GO

                    INSERT INTO MoviesActors VALUES
                    (1,1),
                    (1,2),
                    (1,3),

                    (2,1),
                    (2,2),
                    (2,4),

                    (3,5),
                    (3,6),
                    (3,7),
                    (3,8),
                    (3,9),

                    (4,5),
                    (4,6),
                    (4,7),
                    (4,8),
                    (4,9),

                    (5,5),
                    (5,6),
                    (5,7),
                    (5,8),
                    (5,9),

                    (6,5),
                    (6,6),
                    (6,7),
                    (6,8),
                    (6,9),

                    (7,10),
                    (7,11),
                    (7,12),


                    (8,13),
                    (8,14),

                    (9,5),
                    (9,6),
                    (9,7),
                    (9,8),
                    (9,9),

                    (10,15),
                    (10,16),
                    (10,17),

                    (11,18),
                    (11,19),
                    (11,20),
                    (11,21),
                    (11,22),
                    (11,23),

                    (12,18),
                    (12,19),
                    (12,20),
                    (12,21),
                    (12,22),
                    (12,23),

                    (13,5),
                    (13,24),
                    (13,25),
                    (13,26),

                    (14,9),
                    (14,27),
                    (14,28),
                    (14,29),

                    (15,6),
                    (15,30),
                    (15,31),
                    (15,32),

                    (16,8),
                    (16,34),
                    (16,33),

                    (17,8),
                    (17,34),
                    (17,33),

                    (18,6),
                    (18,9),
                    (18,35),
                    (18,36),
                    (18,37)

                    GO

                    INSERT INTO MoviesGenders VALUES

                    (1,1),
                    (1,5),
                    (1,2),
                    (1,3),

                    (2,1),
                    (2,5),
                    (2,2),
                    (2,3),

                    (3,1),
                    (3,4),
                    (3,2),
                    (3,3),

                    (4,1),
                    (4,4),
                    (4,2),
                    (4,3),

                    (5,1),
                    (5,4),
                    (5,2),
                    (5,3),

                    (6,1),
                    (6,4),
                    (6,2),
                    (6,3),

                    (7,1),
                    (7,2),
                    (7,3),

                    (8,1),
                    (8,2),
                    (8,3),

                    (9,1),
                    (9,2),
                    (9,3),

                    (10,4),
                    (10,2),
                    (10,3),

                    (11,1),
                    (11,5),
                    (11,2),
                    (11,3),


                    (12,1),
                    (12,5),
                    (12,2),
                    (12,3),

                    (13,1),
                    (13,2),
                    (13,3),

                    (14,6),
                    (14,2),
                    (14,3),

                    (15,1),
                    (15,2),
                    (15,3),

                    (16,1),
                    (16,2),
                    (16,3),
                    (16,4),
                    (16,5),

                    (17,1),
                    (17,2),
                    (17,3),
                    (17,4),
                    (17,5),

                    (18,1),
                    (18,2),
                    (18,3)

                    GO
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesActors");

            migrationBuilder.DropTable(
                name: "MoviesGenders");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
