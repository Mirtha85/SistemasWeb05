﻿using static System.Net.WebRequestMethods;

namespace SistemasWeb01.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            BethesdaPieShopDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BethesdaPieShopDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Pies.Any())
            {
                context.AddRange
                (
                    new Pie { Name = "Jordan Womens Air", Price = 1750.69M, ShortDescription = "Jordan Womens WMNS Air Jordan ", LongDescription = "Los zapatos Jordan Women's WMNS Air Jordan son una increíble fusión de estilo y rendimiento diseñados específicamente para las mujeres. Estos zapatos son reconocidos por su emblemático logotipo de Jumpman y su estética icónica que combina colores vibrantes y detalles llamativos. Fabricados con materiales de alta calidad, ofrecemos una combinación perfecta de comodidad y durabilidad. Su diseño aerodinámico y atlético proporciona un ajuste ceñido y una sensación de ligereza en los pies, lo que los convierte en una elección ideal tanto para el uso diario como para actividades deportivas. La amortiguación superior y la tecnología de soporte garantizan una experiencia de uso cómoda y estable, brindando un excelente retorno de energía y protección contra impactos. Ya sea que los uses para el entrenamiento,", Category = Categories["Cheese cakes"], ImageUrl = "https://m.media-amazon.com/images/I/71CCjVEhkTL._AC_UX500_.jpg", InStock = true, IsPieOfTheWeek = true, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/71CCjVEhkTL._AC_UX500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Jordan Boy's Air Jordan", Price = 1063.20M, ShortDescription = "Jordan Boy's Air Jordan", LongDescription = "Los zapatos Jordan Boy's Air Jordan son una elección perfecta para los jóvenes amantes del estilo y el rendimiento. Con el icónico logotipo de Jumpman y un diseño inspirado en la marca Jordan, estos zapatos combinan a la perfección moda y funcionalidad. Fabricados con materiales duraderos y de alta calidad, ofrecen comodidad y resistencia para el uso diario y actividades deportivas. Su diseño aerodinámico y atlético proporciona un ajuste ceñido y una sensación de ligereza en los pies, permitiendo un movimiento ágil y cómodo. Además, cuentan con una amortiguación de primera calidad que brinda una excelente protección contra impactos y una respuesta óptima en cada paso. Ya sea para jugar baloncesto o simplemente lucir un estilo urbano y fresco, los zapatos Jordan Boy's Air Jordan son una elección ideal para los chicos que buscan destacar con confianza y actitud.", Category = Categories["Cheese cakes"], ImageUrl = "https://m.media-amazon.com/images/I/61kxj5AK4KL._AC_UX500_.jpg", InStock = true, IsPieOfTheWeek = true, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/61kxj5AK4KL._AC_UX500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Nike mens Sneaker", Price = 1519.34M, ShortDescription = "Nike mens Sneaker", LongDescription = "Los sneakers Nike para hombres son un verdadero icono de estilo y rendimiento. Estos zapatos combinan una estética moderna con tecnología avanzada para brindar comodidad y un excelente desempeño en cualquier ocasión. Fabricados con materiales de alta calidad y atención meticulosa al detalle, los sneakers Nike para hombres ofrecen durabilidad y resistencia para el uso diario. Su diseño versátil y contemporáneo se adapta a diferentes estilos y actividades, desde entrenamientos intensos hasta looks urbanos casuales. Con características como la amortiguación superior, la tracción óptima y la transpirabilidad, estos sneakers proporcionan una experiencia de uso cómoda y segura, permitiendo movimientos ágiles y flexibles. Además, la marca Nike es conocida por su continua innovación, por lo que los sneakers para hombres incorporan las últimas tecnologías para maximizar el rendimiento y el confort. Ya sea que los uses para correr, hacer ejercicio o simplemente para lucir un estilo vanguardista, los sneakers Nike para hombres son una elección perfecta para aquellos que buscan un calzado versátil y de calidad.", Category = Categories["Cheese cakes"], ImageUrl = "https://m.media-amazon.com/images/I/51sOQ6HcnZL._AC_UX500_.jpg", InStock = true, IsPieOfTheWeek = true, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/51sOQ6HcnZL._AC_UX500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Air Jordan  Mid SE Mens Shoes", Price = 819.80M, ShortDescription = "Air Jordan 1 Mid SE Mens Shoes", LongDescription = "Los Air Jordan 1 Mid SE son unos zapatos para hombres que capturan la esencia del legado y la cultura de la icónica marca Jordan. Estos sneakers destacan por su estilo clásico y contemporáneo, combinando elementos retro con detalles modernos. Fabricados con materiales de alta calidad, ofrecen durabilidad y resistencia para el uso diario. El diseño de corte medio proporciona un ajuste cómodo y sujeción adicional alrededor del tobillo. Los Air Jordan 1 Mid SE presentan el emblemático logotipo de Wings en el lateral, junto con el famoso logo de Jumpman en la lengüeta. La combinación de colores y materiales en el upper crea una estética llamativa y versátil que se adapta a diferentes estilos y ocasiones. Además, la tecnología de amortiguación garantiza una pisada suave y confortable, mientras que la suela de caucho proporciona tracción y durabilidad. Ya sea para lucir un estilo urbano y sofisticado o para expresar tu pasión por el baloncesto, los Air Jordan 1 Mid SE son una elección ideal para los hombres que desean destacar con confianza y elegancia.", Category = Categories["Fruit pies"], ImageUrl = "https://m.media-amazon.com/images/I/61grwvGMylL._AC_UX500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/61grwvGMylL._AC_UX500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Jordan Mens Air Jordan", Price = 1685.75M, ShortDescription = "Jordan Mens Air Jordan", LongDescription = "Los Jordan Men's Air Jordan son unos zapatos legendarios que personifican el estilo y el legado de la marca Jordan. Estos sneakers icónicos han revolucionado la cultura del calzado deportivo y se han convertido en un símbolo de excelencia y dominio en el baloncesto. Fabricados con materiales de primera calidad, ofrecen durabilidad y comodidad para el uso diario o la práctica deportiva. El diseño de los Air Jordan combina una estética elegante y atemporal con detalles distintivos, como el logotipo de Jumpman y el famoso número 23. Su parte superior de cuero o textil proporciona una sensación de sujeción y soporte, mientras que la amortiguación avanzada garantiza una pisada suave y receptiva. La suela de caucho de alta calidad ofrece tracción y resistencia al desgaste, permitiendo movimientos ágiles y rápidos en la cancha. Los Air Jordan son más que solo un par de zapatos: representan la excelencia atlética, la moda y la historia del baloncesto. Para los hombres que buscan un calzado distintivo que combine estilo y rendimiento, los Jordan Men's Air Jordan son una elección insuperable.", Category = Categories["Seasonal pies"], ImageUrl = "https://m.media-amazon.com/images/I/510EuoBpCkL._AC_UX500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/510EuoBpCkL._AC_UX500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Nike Men's Air Jordan ", Price = 1436.32M, ShortDescription = "Nike Men's Air Jordan ", LongDescription = "Los Nike Men's Air Jordan son una línea de sneakers legendarios que combinan la esencia del baloncesto y la moda en un diseño icónico. Estos zapatos capturan la historia y el legado de Michael Jordan, con su distintivo logotipo de Jumpman y su estilo atemporal. Fabricados con materiales de alta calidad, ofrecen una combinación perfecta de comodidad y rendimiento. La tecnología de amortiguación avanzada proporciona una pisada suave y receptiva, mientras que la suela de goma duradera garantiza una tracción confiable en cualquier superficie. Ya sea que los uses para practicar deporte o para lucir un estilo urbano y sofisticado, los Nike Men's Air Jordan son una elección excepcional para los hombres que buscan un calzado distintivo que combine estilo y rendimiento.", Category = Categories["Fruit pies"], ImageUrl = "https://m.media-amazon.com/images/I/61x7Tl7u8QL._AC_UX500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/61x7Tl7u8QL._AC_UX500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "ASHION", Price = 320.55M, ShortDescription = "ASHION", LongDescription = "Los zapatos transpirables para correr son una elección excelente para los entusiastas del running que buscan comodidad y ventilación durante sus carreras. Estos zapatos están diseñados con materiales que permiten una adecuada circulación de aire, ayudando a mantener los pies frescos y secos mientras corres. La parte superior de malla o tejidos transpirables permite que el aire fluya fácilmente, evitando la acumulación de humedad y minimizando la aparición de olores indeseados. Además, suelen contar con perforaciones estratégicas o paneles de ventilación que mejoran aún más la transpirabilidad. Estos zapatos suelen tener una amortiguación adecuada para absorber los impactos y ofrecer una pisada cómoda, y su suela exterior suele ser duradera y con buen agarre para brindar estabilidad en diferentes superficies. Los zapatos transpirables para correr son una elección ideal para aquellos que desean mantener sus pies frescos y secos durante sus sesiones de running, asegurando una experiencia cómoda y sin molestias.", Category = Categories["Fruit pies"], ImageUrl = "https://m.media-amazon.com/images/I/71zkSA3C0jL._AC_SY500._SX._UX._SY._UY_.jpg", InStock = false, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/71zkSA3C0jL._AC_SY500._SX._UX._SY._UY_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Socviis Men's Fashion Sneaker", Price = 330.50M, ShortDescription = "Socviis Men's Fashion Sneaker", LongDescription = "Los Socviis Men's Fashion Sneaker son unos sneakers de moda para hombres que combinan estilo y comodidad en un diseño contemporáneo. Estos zapatos presentan una estética urbana y vanguardista, perfecta para aquellos que buscan destacar con un look moderno y sofisticado. Fabricados con materiales de alta calidad, ofrecen durabilidad y resistencia para el uso diario. La parte superior está confeccionada en cuero sintético o textil, brindando un aspecto elegante y una sensación de suavidad. El diseño de los Socviis Men's Fashion Sneaker incluye detalles de costuras y paneles en contraste, añadiendo un toque de estilo y personalidad. La plantilla acolchada y la suela de goma proporcionan una pisada cómoda y una tracción confiable en diferentes superficies. Ya sea que los uses para completar un atuendo casual o para un look más urbano y audaz, los Socviis Men's Fashion Sneaker son una elección perfecta para los hombres que desean un calzado versátil y a la moda.", Category = Categories["Cheese cakes"], ImageUrl = "https://m.media-amazon.com/images/I/81uVHQaes-S._AC_UY500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81uVHQaes-S._AC_UY500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Basketball Shoes for Men", Price = 276.97M, ShortDescription = "Basketball Shoes for Men", LongDescription = "Las Basketball Shoes for Men son un calzado diseñado específicamente para brindar el máximo rendimiento en la cancha de baloncesto. Estos zapatos están diseñados con características técnicas y tecnología avanzada para satisfacer las demandas del juego rápido y dinámico. Fabricados con materiales de alta calidad, ofrecen durabilidad y resistencia para soportar los movimientos rápidos, los saltos y los cortes bruscos del baloncesto. La parte superior está diseñada para proporcionar un ajuste ceñido y seguro, mientras que la amortiguación de calidad superior en la entresuela ofrece una pisada cómoda y una excelente respuesta de rebote. La suela de caucho con patrones de tracción multidireccional garantiza una tracción sólida en la cancha, permitiendo movimientos ágiles y cambios de dirección rápidos. Ya sea que juegues baloncesto a nivel profesional o simplemente disfrutes de un juego casual, las Basketball Shoes for Men son una elección esencial para aquellos que buscan un rendimiento óptimo y una protección adecuada para sus pies durante el juego.", Category = Categories["Fruit pies"], ImageUrl = "https://m.media-amazon.com/images/I/51CpbaSkC0S._AC_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/51CpbaSkC0S._AC_.jpg", AllergyInformation = "" },
                    new Pie { Name = " High Top Sneakers Breathable", Price = 290.63M, ShortDescription = " High Top Sneakers Breathable", LongDescription = "Las High Top Sneakers Breathable son unos sneakers de caña alta diseñados para ofrecer una combinación perfecta de estilo y comodidad transpirable. Estos zapatos están confeccionados con materiales que permiten una adecuada circulación de aire, manteniendo los pies frescos y secos durante todo el día. Su diseño de caña alta proporciona un mayor soporte y estabilidad alrededor del tobillo, brindando una sensación de seguridad durante la actividad física. Además, la parte superior transpirable permite que el aire fluya fácilmente, evitando la acumulación de humedad y minimizando la aparición de olores indeseados. Estas sneakers ofrecen una combinación perfecta de estilo urbano y funcionalidad, ya sea para un look casual o para actividades deportivas. Las High Top Sneakers Breathable son una elección ideal para aquellos que valoran tanto el estilo como la comodidad transpirable en su calzado.", Category = Categories["Seasonal pies"], ImageUrl = "https://m.media-amazon.com/images/I/81ymKOEArrL._AC_SY500._SX._UX._SY._UY_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81ymKOEArrL._AC_SY500._SX._UX._SY._UY_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Negash Mens Basketball ", Price = 290.33M, ShortDescription = "Negash Mens Basketball ", LongDescription = "Los Negash Men's Basketball son unos zapatos diseñados específicamente para brindar un rendimiento excepcional en la cancha de baloncesto. Estos sneakers ofrecen una combinación perfecta de estilo y funcionalidad para los jugadores apasionados. Fabricados con materiales duraderos y de alta calidad, brindan resistencia y soporte durante los movimientos rápidos y bruscos del juego. El diseño de corte medio y la estructura de soporte en el tobillo proporcionan estabilidad y protección adicionales, permitiendo una mayor confianza en cada salto y cambio de dirección. La suela de goma con patrones de tracción multidireccional garantiza un agarre sólido en la cancha, ofreciendo un movimiento ágil y rápido. Además, la amortiguación de calidad superior en la entresuela proporciona una excelente absorción de impactos, brindando una pisada cómoda y una respuesta de rebote óptima. Los Negash Men's Basketball son la elección perfecta para los jugadores serios que buscan un calzado que combine estilo, rendimiento y durabilidad en la cancha.", Category = Categories["Seasonal pies"], ImageUrl = "https://m.media-amazon.com/images/I/41TSFwQiXeL._AC_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/41TSFwQiXeL._AC_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Big Kid's Jordan", Price = 1312.28M, ShortDescription = "Big Kid's Jordan", LongDescription = "Los Big Kid's Jordan son una línea de sneakers diseñada especialmente para niños mayores y adolescentes. Estos zapatos capturan la esencia del estilo y la herencia de la marca Jordan en un tamaño y diseño adaptados a sus necesidades. Con el emblemático logotipo de Jumpman y detalles distintivos, los Big Kid's Jordan ofrecen un estilo único y vanguardista. Fabricados con materiales duraderos, brindan comodidad y resistencia para el uso diario y actividades deportivas. Su diseño aerodinámico y atlético proporciona un ajuste ceñido y una sensación de ligereza en los pies, permitiendo movimientos ágiles y cómodos. La tecnología de amortiguación garantiza una experiencia de uso suave y cómoda, mientras que la suela de caucho ofrece tracción y durabilidad en diversas superficies. Ya sea que los usen para practicar deportes o simplemente para lucir un estilo urbano y fresco, los Big Kid's Jordan son una elección ideal para los jóvenes que desean destacar con confianza y expresar su estilo personal.", Category = Categories["Cheese cakes"], ImageUrl = "https://m.media-amazon.com/images/I/71zomslhbZL._AC_UY500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/71zomslhbZL._AC_UY500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Beita Mens Basketball ", Price = 110.10M, ShortDescription = "Beita Mens Basketball ", LongDescription = "Los Beita Men's Basketball son unos zapatos diseñados para brindar un rendimiento óptimo en la cancha de baloncesto. Estos sneakers ofrecen una combinación de estilo, comodidad y funcionalidad para los jugadores apasionados. Fabricados con materiales duraderos y de alta calidad, proporcionan resistencia y soporte durante los movimientos rápidos y bruscos del juego. El diseño de corte medio y la estructura de soporte en el tobillo ofrecen estabilidad y protección adicional, permitiendo una mayor confianza en cada salto y cambio de dirección. La suela de goma con patrones de tracción multidireccional garantiza un agarre sólido en la cancha, facilitando movimientos ágiles y rápidos. Además, la amortiguación en la entresuela brinda una absorción de impactos efectiva, ofreciendo una pisada cómoda y una respuesta de rebote óptima. Los Beita Men's Basketball son una elección ideal para los jugadores comprometidos que buscan un calzado que combine estilo, rendimiento y durabilidad en la cancha de baloncesto.", Category = Categories["Seasonal pies"], ImageUrl = "https://m.media-amazon.com/images/I/71dAixFDzFS._AC_UY500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/71dAixFDzFS._AC_UY500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Foothit", Price = 250.80M, ShortDescription = "Foothit", LongDescription = "Los Foothit zapatos para caminar son una opción ideal para aquellos que buscan comodidad y estilo mientras se embarcan en largas caminatas o actividades diarias. Estos zapatos están diseñados para brindar un ajuste cómodo y un soporte adecuado para los pies durante largos períodos de tiempo. Con una parte superior fabricada con materiales transpirables, permiten una adecuada circulación de aire, manteniendo los pies frescos y secos. La suela de goma resistente proporciona una tracción confiable en una variedad de superficies, asegurando una pisada segura y estable. Además, la amortiguación en la entresuela ofrece una absorción de impactos efectiva, reduciendo el estrés en las articulaciones y brindando una experiencia cómoda de caminar. Ya sea para pasear por la ciudad, hacer senderismo ligero o simplemente estar activo durante el día, los Foothit zapatos para caminar son una elección excelente para aquellos que buscan comodidad y estilo en su calzado diario.", Category = Categories["Fruit pies"], ImageUrl = "https://m.media-amazon.com/images/I/61sF5ZAnyhL._AC_UY500_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/61sF5ZAnyhL._AC_UY500_.jpg", AllergyInformation = "" },
                    new Pie { Name = "Giniros Mens Running Shoes", Price = 250.66M, ShortDescription = "Giniros Mens Running Shoes", LongDescription = "Los Giniros Men's Running Shoes son unos zapatos diseñados para brindar un rendimiento excepcional durante las actividades de running. Estos sneakers ofrecen una combinación perfecta de comodidad, estilo y funcionalidad para los corredores apasionados. Fabricados con materiales de alta calidad, brindan durabilidad y resistencia para soportar los rigores de las carreras. La parte superior transpirable permite una adecuada circulación de aire, manteniendo los pies frescos y secos durante todo el recorrido. La amortiguación en la entresuela proporciona una pisada suave y cómoda, absorbiendo eficientemente los impactos para reducir el estrés en las articulaciones. La suela de goma con patrones de tracción multidireccional ofrece un agarre confiable en diferentes superficies, permitiendo movimientos ágiles y seguros. Los Giniros Men's Running Shoes son una elección ideal para los corredores que buscan un calzado que combine rendimiento, estilo y comodidad en cada paso de su recorrido.", Category = Categories["Fruit pies"], ImageUrl = "https://m.media-amazon.com/images/I/71eJkHUuUAL._AC_SY500._SX._UX._SY._UY_.jpg", InStock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/71eJkHUuUAL._AC_SY500._SX._UX._SY._UY_.jpg", AllergyInformation = "" },
                    new Pie { Name = "SRONGKE Men's Athletic ", Price = 230.77M, ShortDescription = "SRONGKE Men's Athletic ", LongDescription = "Los SRONGKE Men's Athletic son unos zapatos atléticos diseñados para brindar un rendimiento óptimo en diversas actividades físicas. Estos sneakers combinan estilo, comodidad y funcionalidad para los hombres activos y deportistas. Fabricados con materiales duraderos y de alta calidad, ofrecen resistencia y soporte durante los movimientos intensos. La parte superior transpirable permite una adecuada circulación de aire, manteniendo los pies frescos y secos durante el ejercicio. La amortiguación en la entresuela proporciona una pisada suave y cómoda, absorbiendo los impactos y reduciendo la fatiga en los pies. La suela de goma con diseño de tracción multidireccional ofrece un agarre confiable en una variedad de superficies, permitiendo movimientos ágiles y estables. Con un diseño moderno y atlético, los SRONGKE Men's Athletic son una elección ideal para actividades deportivas, entrenamientos en el gimnasio o simplemente para lucir un estilo activo y dinámico en tu día a día.", Category = Categories["Cheese cakes"], ImageUrl = "https://m.media-amazon.com/images/I/71N51WYkqtL._AC_UY500_.jpg", InStock = false, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://m.media-amazon.com/images/I/71N51WYkqtL._AC_UY500_.jpg", AllergyInformation = "" }

                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fruit pies" },
                        new Category { CategoryName = "Cheese cakes" },
                        new Category { CategoryName = "Seasonal pies" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}