﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookClub.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrationBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "IsRead", "Title" },
                values: new object[,]
                {
                    { 1, "Джон Даккет", "Эта книга – самый простой и интересный способ изучить HTML и CSS. Независимо от стоящей перед вами задачи: спроектировать и разработать веб-сайт с нуля или получить больше контроля над уже существующим сайтом, эта книга поможет вам создать привлекательный, дружелюбный к пользователю веб-контент. Простой визуальный способ подачи информации с понятными примерами и небольшим фрагментом кода знакомит с новой темой на каждой странице. Вы найдете практические советы о том, как организовать и спроектировать страницы вашего сайта, и после прочтения книги сможете разработать свой веб-сайт профессионального вида и удобный в использовании.", false, "HTML и CSS. Разработка сайтов" },
                    { 2, "Дэвид Фленаган", "JavaScript - это язык программирования для веб-сети, который в настоящее время используется большим количеством разработчиков программного обеспечения, чем любой другой язык программирования. В течение почти 25 лет этот бестселлер служил исчерпывающим руководством для программистов на JavaScript, и новое издание книги полностью обновлено с целью охвата версии 2020 языка JavaScript. Повсюду в книге вы будете находить яркие и привлекательные примеры кода. Вам также предлагаются новые главы, в которых раскрываются классы, модули, итераторы, генераторы, объекты Promise и async/await.", false, "JavaScript. Подробное руководство" },
                    { 3, "Эндрю Стиллмен ", "Серия Head First позволяет сразу приступить к созданию собственного кода на C#, даже если у вас нет никакого опыта программирования. Не нужно тратить время на изучение скучных спецификаций и примеров! Вы освоите необходимый минимум инструментов и сразу приступите к забавным и интересным программным проектам, от разработки 3D-игры до создания серьезного приложения и работы с данными. Четвертое издание книги было полностью обновлено и переработано, чтобы рассказать о возможностях современных C#, Visual Studio и .NET, оно будет интересно всем, кто изучает язык программирования С#. Особенностью данного издания является уникальный способ подачи материала, выделяющий серию «Head First» издательства OReilly в ряду множества скучных книг, посвященных программированию.", false, "Изучаем C#" },
                    { 4, "Эрик Фримен", "Не имеет смысла каждый раз изобретать велосипед, лучше сразу освоить приемы проектирования, которые уже созданы людьми, сталкивавшимися с аналогичными задачами. В этой книге рассказано, какие паттерны действительно важны, когда и при каких условиях ими необходимо пользоваться, как применить их в ваших проектах и на каких принципах объектно-ориентированного проектирования они построены. Присоединяйтесь к сотням тысяч разработчиков, которые повысили свою квалификацию объектно-ориентированного проектирования благодаря книге \"Head First. Паттерны проектирования\".  Если вы уже читали книги из серии Head First, то знаете, что вас ждет визуально насыщенный формат, разработанный с учетом особенностей работы мозга. В книге \"Head First. Паттерны проектирования\" принципы и паттерны проектирования представлены так, чтобы вы не заснули, читая книгу, научились решать реальные задачи проектирования программных продуктов и общаться на языке паттернов с другими участниками вашей команды.", false, "Паттерны проектирования" },
                    { 5, "Эндрю Лок", "Создавайте полнофункциональные веб-приложения, которые работают где угодно.\r\nРазработчики любят ASP.NET Core за его библиотеки и готовые компоненты, повышающие производительность. Версия 5.0 предлагает новые функции для серверных приложений, а также фоновые службы для кросс-платформенной разработки.\r\nПеред вами исчерпывающее руководство по созданию веб-приложений с помощью ASP.NET Core 5.0. Перехо-дите от базовых концепций HTTP к расширенной настройке фреймворка. Иллюстрации и код с аннотациями делают процесс обучения наглядным и легким. Освойте вопросы, касающиеся входа в приложение, внедрения зависимостей, безопасности и узнайте о новейших функциях ASP.NET Core, включая Razor Pages и новую парадигму хостинга.\r\nИздание предназначено для разработчиков C# среднего уровня.", false, "ASP.NET Core в действии" },
                    { 6, "Дейли Калеб", "Node.js является главной средой для программирования на стороне сервера, MongoDB - самой распространенной базой данных типа NoSQL и Angular - ведущим каркасом для разработки веб-приложений на стороне клиента по шаблону MVC. Совместно они образуют легко реализуемый, полностью интегрированный комплекс веб-разработки, предоставляющий специалистам в веб-программировании отличную возможность создавать высокопроизводительные сайты и приложения полностью на языке JavaScript: от сервера до клиента.", false, "Разработка веб-приложений с помощью Node.js, MongoDB и Angular" },
                    { 7, "Стефанов Стоян", "Незаменимая книга по React — технологии с открытым исходным кодом для быстрого создания многофункциональных веб-приложений. Второе издание, обновленное с учетом последней версии React, показывает, как создавать компоненты React и организовывать их в удобные для сопровождения крупномасштабные приложения. Если вы знаете синтаксис JavaScript, то сразу можете приступать к работе.\r\nПо ходу чтения разработчики и программисты создадут полноценное приложение. Вы быстро поймете, почему многие выбирают React для разработки веб-приложений.", false, "React. Быстрый старт" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}