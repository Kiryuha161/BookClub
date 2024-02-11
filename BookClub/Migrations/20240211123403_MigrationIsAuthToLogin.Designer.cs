﻿// <auto-generated />
using System;
using BookClub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookClub.Migrations
{
    [DbContext(typeof(BookClubDbContext))]
    [Migration("20240211123403_MigrationIsAuthToLogin")]
    partial class MigrationIsAuthToLogin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookClub.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Джон Даккет",
                            Description = "Эта книга – самый простой и интересный способ изучить HTML и CSS. Независимо от стоящей перед вами задачи: спроектировать и разработать веб-сайт с нуля или получить больше контроля над уже существующим сайтом, эта книга поможет вам создать привлекательный, дружелюбный к пользователю веб-контент. Простой визуальный способ подачи информации с понятными примерами и небольшим фрагментом кода знакомит с новой темой на каждой странице. Вы найдете практические советы о том, как организовать и спроектировать страницы вашего сайта, и после прочтения книги сможете разработать свой веб-сайт профессионального вида и удобный в использовании.",
                            ImageUrl = "https://files.books.ru/pic/3557001-3558000/3557131/973108900c.jpg",
                            IsRead = false,
                            Title = "HTML и CSS. Разработка сайтов"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Дэвид Фленаган",
                            Description = "JavaScript - это язык программирования для веб-сети, который в настоящее время используется большим количеством разработчиков программного обеспечения, чем любой другой язык программирования. В течение почти 25 лет этот бестселлер служил исчерпывающим руководством для программистов на JavaScript, и новое издание книги полностью обновлено с целью охвата версии 2020 языка JavaScript. Повсюду в книге вы будете находить яркие и привлекательные примеры кода. Вам также предлагаются новые главы, в которых раскрываются классы, модули, итераторы, генераторы, объекты Promise и async/await.",
                            ImageUrl = "https://sun9-39.userapi.com/impg/kl1PiBYGZCRXMYpO9UuwaODuyMp2o5mCZxif0w/GzwGaBJWk9Q.jpg?size=556x807&quality=96&sign=20e286d6b8fe8e2bf1306b551c1276f2&c_uniq_tag=NktdlktIn7ul5i56FpbQKAf8ZZdhs0_LUAKqY-UAFNI&type=album",
                            IsRead = false,
                            Title = "JavaScript. Подробное руководство"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Эндрю Стиллмен",
                            Description = "Серия Head First позволяет сразу приступить к созданию собственного кода на C#, даже если у вас нет никакого опыта программирования. Не нужно тратить время на изучение скучных спецификаций и примеров! Вы освоите необходимый минимум инструментов и сразу приступите к забавным и интересным программным проектам, от разработки 3D-игры до создания серьезного приложения и работы с данными. Четвертое издание книги было полностью обновлено и переработано, чтобы рассказать о возможностях современных C#, Visual Studio и .NET, оно будет интересно всем, кто изучает язык программирования С#. Особенностью данного издания является уникальный способ подачи материала, выделяющий серию «Head First» издательства OReilly в ряду множества скучных книг, посвященных программированию.",
                            ImageUrl = "https://synergy.ru/assets/upload/news/academy/and4.jpg",
                            IsRead = false,
                            Title = "Изучаем C#"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Эрик Фримен",
                            Description = "Не имеет смысла каждый раз изобретать велосипед, лучше сразу освоить приемы проектирования, которые уже созданы людьми, сталкивавшимися с аналогичными задачами. В этой книге рассказано, какие паттерны действительно важны, когда и при каких условиях ими необходимо пользоваться, как применить их в ваших проектах и на каких принципах объектно-ориентированного проектирования они построены. Присоединяйтесь к сотням тысяч разработчиков, которые повысили свою квалификацию объектно-ориентированного проектирования благодаря книге \"Head First. Паттерны проектирования\".  Если вы уже читали книги из серии Head First, то знаете, что вас ждет визуально насыщенный формат, разработанный с учетом особенностей работы мозга. В книге \"Head First. Паттерны проектирования\" принципы и паттерны проектирования представлены так, чтобы вы не заснули, читая книгу, научились решать реальные задачи проектирования программных продуктов и общаться на языке паттернов с другими участниками вашей команды.",
                            ImageUrl = "https://ndc.book24.ru/resize/820x1180/iblock/90f/90f0287fb8b4ad1c57e2613dfa5f2aeb/ff8757b0dfcc866833e499090194d9cd.jpg",
                            IsRead = false,
                            Title = "Паттерны проектирования"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Эндрю Лок",
                            Description = "Создавайте полнофункциональные веб-приложения, которые работают где угодно.\r\nРазработчики любят ASP.NET Core за его библиотеки и готовые компоненты, повышающие производительность. Версия 5.0 предлагает новые функции для серверных приложений, а также фоновые службы для кросс-платформенной разработки.\r\nПеред вами исчерпывающее руководство по созданию веб-приложений с помощью ASP.NET Core 5.0. Перехо-дите от базовых концепций HTTP к расширенной настройке фреймворка. Иллюстрации и код с аннотациями делают процесс обучения наглядным и легким. Освойте вопросы, касающиеся входа в приложение, внедрения зависимостей, безопасности и узнайте о новейших функциях ASP.NET Core, включая Razor Pages и новую парадигму хостинга.\r\nИздание предназначено для разработчиков C# среднего уровня.",
                            ImageUrl = "https://cdn.img-gorod.ru/nomenclature/28/687/2868777.jpg",
                            IsRead = false,
                            Title = "ASP.NET Core в действии"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Дейли Калеб",
                            Description = "Node.js является главной средой для программирования на стороне сервера, MongoDB - самой распространенной базой данных типа NoSQL и Angular - ведущим каркасом для разработки веб-приложений на стороне клиента по шаблону MVC. Совместно они образуют легко реализуемый, полностью интегрированный комплекс веб-разработки, предоставляющий специалистам в веб-программировании отличную возможность создавать высокопроизводительные сайты и приложения полностью на языке JavaScript: от сервера до клиента.",
                            ImageUrl = "https://avatars.mds.yandex.net/i?id=58cc02a626f1bdc1260a3e0cec5db747728d30f2-10640163-images-thumbs&n=13",
                            IsRead = false,
                            Title = "Разработка веб-приложений с помощью Node.js, MongoDB и Angular"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Стефанов Стоян",
                            Description = "Незаменимая книга по React — технологии с открытым исходным кодом для быстрого создания многофункциональных веб-приложений. Второе издание, обновленное с учетом последней версии React, показывает, как создавать компоненты React и организовывать их в удобные для сопровождения крупномасштабные приложения. Если вы знаете синтаксис JavaScript, то сразу можете приступать к работе.\r\nПо ходу чтения разработчики и программисты создадут полноценное приложение. Вы быстро поймете, почему многие выбирают React для разработки веб-приложений.",
                            ImageUrl = "https://img2.festima.ru/1/yAhOQTG6uAPG1wen",
                            IsRead = false,
                            Title = "React. Быстрый старт"
                        });
                });

            modelBuilder.Entity("BookClub.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAuth")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("BookClub.Models.UserReadBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("UserReadBooks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookClub.Models.UserReadBook", b =>
                {
                    b.HasOne("BookClub.Models.Book", null)
                        .WithMany("ReadBookUsers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookClub.Models.Book", b =>
                {
                    b.Navigation("ReadBookUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
