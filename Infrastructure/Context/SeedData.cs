// ============================================
// Infrastructure/Context/Configurations/SeedData.cs
// ============================================

using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context.Configurations
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedHeritageSites(builder);
            SeedArchitecturalElements(builder);
            SeedClimateData(builder);
            SeedArticles(builder);
        }

        // ==================== 1. المواقع الأثرية ====================
        private static void SeedHeritageSites(ModelBuilder builder)
        {
            builder.Entity<HeritageSite>().HasData(
                new HeritageSite
                {
                    Id = 1,
                    NameAr = "معبد الكرنك",
                    NameEn = "Karnak Temple",
                    DescriptionAr = "أكبر مجمع معابد في مصر القديمة، يضم معابد وكنائس ومقاصير عديدة",
                    DescriptionEn = "The largest ancient temple complex in Egypt",
                    Governorate = "الأقصر",
                    Address = "الكرنك، الأقصر",
                    Latitude = 25.7188,
                    Longitude = 32.6573,
                    ConstructionYear = -2055,
                    HistoricalPeriod = "الدولة الوسطى - الحديثة",
                    Status = SiteStatus.Active,
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new HeritageSite
                {
                    Id = 2,
                    NameAr = "قلعة قايتباي",
                    NameEn = "Qaitbay Citadel",
                    DescriptionAr = "قلعة دفاعية بناها السلطان الأشرف قايتباي على ساحل البحر المتوسط",
                    DescriptionEn = "A defensive fortress built by Sultan Al-Ashraf Qaitbay",
                    Governorate = "الإسكندرية",
                    Address = "رأس التين، الإسكندرية",
                    Latitude = 31.2139,
                    Longitude = 29.8856,
                    ConstructionYear = 1477,
                    HistoricalPeriod = "العصر المملوكي",
                    Status = SiteStatus.Active,
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new HeritageSite
                {
                    Id = 3,
                    NameAr = "مسجد أحمد بن طولون",
                    NameEn = "Ibn Tulun Mosque",
                    DescriptionAr = "ثالث أقدم مسجد في مصر وأكبر مساجد القاهرة من حيث المساحة",
                    DescriptionEn = "The third oldest mosque in Egypt and the largest in Cairo",
                    Governorate = "القاهرة",
                    Address = "السيدة زينب، القاهرة",
                    Latitude = 30.0286,
                    Longitude = 31.2497,
                    ConstructionYear = 879,
                    HistoricalPeriod = "العصر الطولوني",
                    Status = SiteStatus.Active,
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new HeritageSite
                {
                    Id = 4,
                    NameAr = "معبد أبو سمبل",
                    NameEn = "Abu Simbel Temples",
                    DescriptionAr = "معبدان ضخمان منحوتان في الصخر بناهما رمسيس الثاني",
                    DescriptionEn = "Two massive rock-cut temples built by Ramesses II",
                    Governorate = "أسوان",
                    Address = "أبو سمبل، أسوان",
                    Latitude = 22.3372,
                    Longitude = 31.6258,
                    ConstructionYear = -1264,
                    HistoricalPeriod = "الدولة الحديثة",
                    Status = SiteStatus.Active,
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new HeritageSite
                {
                    Id = 5,
                    NameAr = "دير سانت كاترين",
                    NameEn = "Saint Catherine's Monastery",
                    DescriptionAr = "أقدم دير مسيحي في العالم لا يزال يعمل",
                    DescriptionEn = "The oldest continuously operating Christian monastery",
                    Governorate = "جنوب سيناء",
                    Address = "سانت كاترين، جنوب سيناء",
                    Latitude = 28.5561,
                    Longitude = 33.9758,
                    ConstructionYear = 565,
                    HistoricalPeriod = "العصر البيزنطي",
                    Status = SiteStatus.Active,
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new HeritageSite
                {
                    Id = 6,
                    NameAr = "قصر البارون",
                    NameEn = "Baron Empain Palace",
                    DescriptionAr = "قصر على الطراز الهندي بناه البارون إمبان مؤسس حي مصر الجديدة",
                    DescriptionEn = "An Indian-style palace built by Baron Empain",
                    Governorate = "القاهرة",
                    Address = "مصر الجديدة، القاهرة",
                    Latitude = 30.0875,
                    Longitude = 31.3294,
                    ConstructionYear = 1911,
                    HistoricalPeriod = "العصر الحديث",
                    Status = SiteStatus.UnderRestoration,
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }

        // ==================== 2. العناصر المعمارية ====================
        private static void SeedArchitecturalElements(ModelBuilder builder)
        {
            builder.Entity<ArchitecturalElement>().HasData(
                // معبد الكرنك
                new ArchitecturalElement
                {
                    Id = 1,
                    HeritageSiteId = 1,
                    NameAr = "أعمدة البهو الكبير",
                    NameEn = "Great Hypostyle Hall Columns",
                    DescriptionAr = "134 عموداً ضخماً من الحجر الرملي",
                    DescriptionEn = "134 massive sandstone columns",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Fair,
                    Location = "البهو الكبير",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 2,
                    HeritageSiteId = 1,
                    NameAr = "مسلة حتشبسوت",
                    NameEn = "Hatshepsut's Obelisk",
                    DescriptionAr = "مسلة من الجرانيت الوردي",
                    DescriptionEn = "Pink granite obelisk",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Good,
                    Location = "الفناء المركزي",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 3,
                    HeritageSiteId = 1,
                    NameAr = "نقوش الجدران",
                    NameEn = "Wall Reliefs",
                    DescriptionAr = "نقوش ورسومات ملونة على الجدران",
                    DescriptionEn = "Colored carvings and paintings on walls",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Poor,
                    Location = "الجدران الداخلية",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                // قلعة قايتباي
                new ArchitecturalElement
                {
                    Id = 4,
                    HeritageSiteId = 2,
                    NameAr = "الأسوار الخارجية",
                    NameEn = "Outer Walls",
                    DescriptionAr = "أسوار دفاعية من الحجر الجيري",
                    DescriptionEn = "Defensive limestone walls",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Fair,
                    Location = "المحيط الخارجي",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 5,
                    HeritageSiteId = 2,
                    NameAr = "البوابة الرئيسية",
                    NameEn = "Main Gate",
                    DescriptionAr = "بوابة خشبية مصفحة بالحديد",
                    DescriptionEn = "Wooden gate reinforced with iron",
                    MaterialType = MaterialType.Wood,
                    CurrentCondition = ElementCondition.Poor,
                    Location = "المدخل الرئيسي",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 6,
                    HeritageSiteId = 2,
                    NameAr = "أبراج المراقبة",
                    NameEn = "Watch Towers",
                    DescriptionAr = "أبراج حجرية للمراقبة والدفاع",
                    DescriptionEn = "Stone towers for surveillance and defense",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Good,
                    Location = "أركان القلعة",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                // مسجد ابن طولون
                new ArchitecturalElement
                {
                    Id = 7,
                    HeritageSiteId = 3,
                    NameAr = "المئذنة الملوية",
                    NameEn = "Spiral Minaret",
                    DescriptionAr = "مئذنة حلزونية فريدة من الطوب",
                    DescriptionEn = "Unique spiral brick minaret",
                    MaterialType = MaterialType.Brick,
                    CurrentCondition = ElementCondition.Good,
                    Location = "الجانب الشمالي",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 8,
                    HeritageSiteId = 3,
                    NameAr = "الأقواس المدببة",
                    NameEn = "Pointed Arches",
                    DescriptionAr = "أقواس مدببة من الطوب والجص",
                    DescriptionEn = "Pointed arches made of brick and plaster",
                    MaterialType = MaterialType.Brick,
                    CurrentCondition = ElementCondition.Fair,
                    Location = "الأروقة",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 9,
                    HeritageSiteId = 3,
                    NameAr = "زخارف الجص",
                    NameEn = "Stucco Decorations",
                    DescriptionAr = "زخارف هندسية ونباتية من الجص",
                    DescriptionEn = "Geometric and floral stucco decorations",
                    MaterialType = MaterialType.Plaster,
                    CurrentCondition = ElementCondition.Poor,
                    Location = "النوافذ والمحراب",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                // معبد أبو سمبل
                new ArchitecturalElement
                {
                    Id = 10,
                    HeritageSiteId = 4,
                    NameAr = "تماثيل رمسيس الثاني",
                    NameEn = "Ramesses II Colossi",
                    DescriptionAr = "أربعة تماثيل ضخمة منحوتة في الصخر",
                    DescriptionEn = "Four massive rock-carved statues",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Good,
                    Location = "واجهة المعبد الكبير",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 11,
                    HeritageSiteId = 4,
                    NameAr = "قدس الأقداس",
                    NameEn = "Inner Sanctuary",
                    DescriptionAr = "الحجرة الداخلية للمعبد",
                    DescriptionEn = "The innermost chamber of the temple",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Excellent,
                    Location = "نهاية المعبد",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                // دير سانت كاترين
                new ArchitecturalElement
                {
                    Id = 12,
                    HeritageSiteId = 5,
                    NameAr = "الكنيسة البيزنطية",
                    NameEn = "Byzantine Church",
                    DescriptionAr = "كنيسة التجلي الأصلية",
                    DescriptionEn = "The original Church of Transfiguration",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Good,
                    Location = "وسط الدير",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 13,
                    HeritageSiteId = 5,
                    NameAr = "أيقونات الدير",
                    NameEn = "Monastery Icons",
                    DescriptionAr = "مجموعة أيقونات نادرة من العصر البيزنطي",
                    DescriptionEn = "Rare collection of Byzantine icons",
                    MaterialType = MaterialType.Wood,
                    CurrentCondition = ElementCondition.Fair,
                    Location = "داخل الكنيسة",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                // قصر البارون
                new ArchitecturalElement
                {
                    Id = 14,
                    HeritageSiteId = 6,
                    NameAr = "البرج الرئيسي",
                    NameEn = "Main Tower",
                    DescriptionAr = "برج على الطراز الهندي الكمبودي",
                    DescriptionEn = "Tower in Hindu-Cambodian style",
                    MaterialType = MaterialType.Concrete,
                    CurrentCondition = ElementCondition.Fair,
                    Location = "وسط القصر",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new ArchitecturalElement
                {
                    Id = 15,
                    HeritageSiteId = 6,
                    NameAr = "التماثيل الخارجية",
                    NameEn = "Exterior Statues",
                    DescriptionAr = "تماثيل بوذية وهندوسية",
                    DescriptionEn = "Buddhist and Hindu statues",
                    MaterialType = MaterialType.Stone,
                    CurrentCondition = ElementCondition.Poor,
                    Location = "الواجهات الخارجية",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }

        // ==================== 3. البيانات المناخية ====================
        private static void SeedClimateData(ModelBuilder builder)
        {
            builder.Entity<ClimateData>().HasData(
                // الأقصر - معبد الكرنك
                new ClimateData
                {
                    Id = 1,
                    HeritageSiteId = 1,
                    RecordedAt = new DateTime(2024, 6, 15, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 42.5,
                    Humidity = 25,
                    Rainfall = 0,
                    WindSpeed = 15,
                    WindDirection = "N",
                    AirPollutionIndex = 45,
                    DataSource = "محطة أرصاد الأقصر",
                    IsManualEntry = false
                },
                new ClimateData
                {
                    Id = 2,
                    HeritageSiteId = 1,
                    RecordedAt = new DateTime(2024, 1, 15, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 22.0,
                    Humidity = 45,
                    Rainfall = 2,
                    WindSpeed = 10,
                    WindDirection = "NW",
                    AirPollutionIndex = 35,
                    DataSource = "محطة أرصاد الأقصر",
                    IsManualEntry = false
                },
                // الإسكندرية - قلعة قايتباي
                new ClimateData
                {
                    Id = 3,
                    HeritageSiteId = 2,
                    RecordedAt = new DateTime(2024, 7, 20, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 32.0,
                    Humidity = 75,
                    Rainfall = 0,
                    WindSpeed = 25,
                    WindDirection = "NE",
                    AirPollutionIndex = 65,
                    DataSource = "محطة أرصاد الإسكندرية",
                    IsManualEntry = false
                },
                new ClimateData
                {
                    Id = 4,
                    HeritageSiteId = 2,
                    RecordedAt = new DateTime(2024, 12, 10, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 18.0,
                    Humidity = 80,
                    Rainfall = 25,
                    WindSpeed = 35,
                    WindDirection = "NW",
                    AirPollutionIndex = 50,
                    DataSource = "محطة أرصاد الإسكندرية",
                    IsManualEntry = false
                },
                // القاهرة - مسجد ابن طولون
                new ClimateData
                {
                    Id = 5,
                    HeritageSiteId = 3,
                    RecordedAt = new DateTime(2024, 8, 1, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 38.0,
                    Humidity = 50,
                    Rainfall = 0,
                    WindSpeed = 12,
                    WindDirection = "S",
                    AirPollutionIndex = 120,
                    DataSource = "محطة أرصاد القاهرة",
                    IsManualEntry = false
                },
                new ClimateData
                {
                    Id = 6,
                    HeritageSiteId = 3,
                    RecordedAt = new DateTime(2024, 2, 15, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 20.0,
                    Humidity = 55,
                    Rainfall = 5,
                    WindSpeed = 18,
                    WindDirection = "W",
                    AirPollutionIndex = 95,
                    DataSource = "محطة أرصاد القاهرة",
                    IsManualEntry = false
                },
                // أسوان - أبو سمبل
                new ClimateData
                {
                    Id = 7,
                    HeritageSiteId = 4,
                    RecordedAt = new DateTime(2024, 6, 1, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 45.0,
                    Humidity = 15,
                    Rainfall = 0,
                    WindSpeed = 20,
                    WindDirection = "SE",
                    AirPollutionIndex = 30,
                    DataSource = "محطة أرصاد أسوان",
                    IsManualEntry = false
                },
                // سيناء - دير سانت كاترين
                new ClimateData
                {
                    Id = 8,
                    HeritageSiteId = 5,
                    RecordedAt = new DateTime(2024, 1, 20, 12, 0, 0, DateTimeKind.Utc),
                    Temperature = 5.0,
                    Humidity = 40,
                    Rainfall = 15,
                    WindSpeed = 30,
                    WindDirection = "N",
                    AirPollutionIndex = 20,
                    DataSource = "محطة أرصاد سانت كاترين",
                    IsManualEntry = false
                }
            );
        }

        // ==================== 4. المقالات ====================
        private static void SeedArticles(ModelBuilder builder)
        {
            builder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    TitleAr = "تأثير التغيرات المناخية على الآثار الحجرية",
                    TitleEn = "Impact of Climate Change on Stone Monuments",
                    ContentAr = "تتعرض الآثار الحجرية لتأثيرات مناخية متعددة منها التجوية الحرارية والتملح...",
                    ContentEn = "Stone monuments are exposed to various climate impacts including thermal weathering...",
                    Summary = "دراسة شاملة عن تأثيرات المناخ على الحجر",
                    Category = "أبحاث",
                    IsPublished = true,
                    CreatedAt = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc),
                    PublishedAt = new DateTime(2024, 1, 20, 0, 0, 0, DateTimeKind.Utc)
                },
                new Article
                {
                    Id = 2,
                    TitleAr = "أساليب الحفاظ على الأخشاب الأثرية",
                    TitleEn = "Conservation Methods for Historic Wood",
                    ContentAr = "تتطلب الأخشاب الأثرية عناية خاصة نظراً لحساسيتها للرطوبة والحشرات...",
                    ContentEn = "Historic wood requires special care due to its sensitivity to humidity and insects...",
                    Summary = "دليل شامل لحفظ الأخشاب التاريخية",
                    Category = "ترميم",
                    IsPublished = true,
                    CreatedAt = new DateTime(2024, 2, 10, 0, 0, 0, DateTimeKind.Utc),
                    PublishedAt = new DateTime(2024, 2, 15, 0, 0, 0, DateTimeKind.Utc)
                },
                new Article
                {
                    Id = 3,
                    TitleAr = "الرطوبة وتأثيرها على المباني التاريخية",
                    TitleEn = "Humidity and Its Effects on Historic Buildings",
                    ContentAr = "تعد الرطوبة من أخطر العوامل المؤثرة على المباني الأثرية...",
                    ContentEn = "Humidity is one of the most dangerous factors affecting historic buildings...",
                    Summary = "تحليل تأثير الرطوبة على المباني الأثرية",
                    Category = "أبحاث",
                    IsPublished = true,
                    CreatedAt = new DateTime(2024, 3, 5, 0, 0, 0, DateTimeKind.Utc),
                    PublishedAt = new DateTime(2024, 3, 10, 0, 0, 0, DateTimeKind.Utc)
                },
                new Article
                {
                    Id = 4,
                    TitleAr = "تقنيات التوثيق الرقمي للمباني الأثرية",
                    TitleEn = "Digital Documentation Techniques for Heritage Buildings",
                    ContentAr = "تساهم التقنيات الحديثة في توثيق المباني الأثرية بدقة عالية...",
                    ContentEn = "Modern technologies contribute to documenting heritage buildings with high accuracy...",
                    Summary = "استخدام التكنولوجيا في توثيق التراث",
                    Category = "تكنولوجيا",
                    IsPublished = false,
                    CreatedAt = new DateTime(2024, 4, 1, 0, 0, 0, DateTimeKind.Utc),
                    PublishedAt = null
                }
            );
        }
    }
}