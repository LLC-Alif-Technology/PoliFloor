using AutoMapper;
using KagamaAdmin.Mappings;
using KagamaAdmin.Models;
using KagamaModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net.Http;

namespace KagamaAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddMvc();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/cp/Sign/In");
                });

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EFDBContext>(options => options.UseSqlServer(connection));

            services.AddMemoryCache();
            services.AddTransient<IKagamaRepository, MsSqlDataService>();

            services.AddDistributedMemoryCache();
            services.AddSession(opts =>
            {
                opts.Cookie.IsEssential = true;
            });

            var mappingConfig = new MapperConfiguration(x =>
            {
                x.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var options = new RewriteOptions()
                .AddRedirect("(.*)/$", "$1", 301)
                .AddRedirect("services.html", "services", 301)
                .AddRedirect("odnotonnie_poli.html", "epoksidnye-poly", 301)
                .AddRedirect("promishlennie_poli.html", "promyshlennye-poly", 301)
                .AddRedirect("sportivnie_poli.html", "sportivnoe-pokrytie", 301)
                .AddRedirect("poli_3d.html", "3d-poly", 301)
                .AddRedirect("about.html", "about", 301)
                .AddRedirect("shop.html", "catalog", 301)
                .AddRedirect("shop/nalivnie_poli.html", "catalog/nalivnye-poly", 301)
                .AddRedirect("shop/mikrozement_mikrobeton.html", "catalog/loft-pokrytiya", 301)
                .AddRedirect("shop/instrumenti.html", "catalog/instrument", 301)
                .AddRedirect("shop/photoizobrazheniya.html", "catalog/fotoizobrazheniya", 301)
                .AddRedirect("shop/decorativnie-napolniteli.html", "catalog/dekorativnye-napolniteli", 301)
                .AddRedirect("shop/cleaning.html", "catalog/klining-i-zashchita", 301)
                .AddRedirect("shop/product/47.html", "catalog/tikstropnaya-shpatlevka", 301)
                .AddRedirect("shop/product/48.html", "catalog/epoksidnyj-grunt", 301)
                .AddRedirect("shop/product/89.html", "catalog/dekorativnyj-ehpoksidnyj-nalivnoj-pol", 301)
                .AddRedirect("shop/product/49.html", "catalog/promyshlennyj-ehpoksidnyj-nalivnoj-pol", 301)
                .AddRedirect("shop/product/50.html", "catalog/prozrachnyj-3d-nalivnoj-pol", 301)
                .AddRedirect("shop/product/5.html", "catalog/lak-matovyj", 301)
                .AddRedirect("shop/product/68.html", "catalog/mikrobeton", 301)
                .AddRedirect("shop/product/82.html", "catalog/antistaticheskij-grunt", 301)
                .AddRedirect("shop/product/74.html", "catalog/mikrocement", 301)
                .AddRedirect("shop/product/21.html", "catalog/chipsy", 301)
                .AddRedirect("shop/product/20.html", "catalog/floki-(blestki)", 301)
                .AddRedirect("shop/product/64.html", "catalog/pesok-kvarcevyj", 301)
                .AddRedirect("gallery.html", "gallery", 301)
                .AddRedirect("gallery/coatings.html", "gallery/poly-po-tipu-pokrytiya", 301)
                .AddRedirect("gallery/rooms.html", "gallery/poly-po-tipu-pomeshcheniya", 301)
                .AddRedirect("gallery/colors.html", "gallery/poly-po-osnovnomu-cvetu", 301)
                .AddRedirect("gallery/trainings.html", "gallery/obuchenie", 301)
                .AddRedirect("gallery/coatings/3d_poli.html", "gallery/3d-poly", 301)
                .AddRedirect("gallery/coatings/mikrocement.html", "gallery/mikrocement", 301)
                .AddRedirect("gallery/coatings/terracco.html", "gallery/terracco", 301)
                .AddRedirect("gallery/coatings/sport_poli.html", "gallery/sportivnye-pokrytiya", 301)
                .AddRedirect("gallery/coatings/odnot_poli.html", "gallery/epoksidnye-poly", 301)
                .AddRedirect("gallery/coatings/prom_poli.html", "gallery/promyshlennye-poly", 301)
                .AddRedirect("gallery/rooms/v_kvartire.html", "gallery/v-kvartire", 301)
                .AddRedirect("gallery/rooms/v_garazhe.html", "gallery/v-garazhe", 301)
                .AddRedirect("gallery/rooms/v_shkole.html", "gallery/v-shkole", 301)
                .AddRedirect("gallery/rooms/v_restorane.html", "gallery/v-restorane", 301)
                .AddRedirect("gallery/rooms/v_fitnes_klube.html", "gallery/v-fitnes-klube", 301)
                .AddRedirect("gallery/rooms/v_dome.html", "gallery/v-dome", 301)
                .AddRedirect("gallery/rooms/v_office.html", "gallery/v-ofise", 301)
                .AddRedirect("gallery/rooms/v_tualete.html", "gallery/v-tualete", 301)
                .AddRedirect("gallery/rooms/v_torgovom_centre.html", "gallery/v-torgovom-centre", 301)
                .AddRedirect("gallery/rooms/na_sklade.html", "gallery/na-sklade", 301)
                .AddRedirect("gallery/rooms/v_tsehu.html", "gallery/v-cekhu", 301)
                .AddRedirect("gallery/rooms/v_klube.html", "gallery/v-klube", 301)
                .AddRedirect("gallery/rooms/v_detskoj.html", "gallery/v-detskoj", 301)
                .AddRedirect("gallery/rooms/v_vannoj.html", "gallery/v-vannoj", 301)
                .AddRedirect("gallery/rooms/v_magazine.html", "gallery/v-magazine", 301)
                .AddRedirect("gallery/rooms/v_butik.html", "gallery/v-butike", 301)
                .AddRedirect("gallery/rooms/na_kuhnie.html", "gallery/na-kukhne", 301)
                .AddRedirect("gallery/rooms/v_komnate.html", "gallery/v-komnate", 301)
                .AddRedirect("gallery/rooms/v-muzee.html", "gallery/v-muzee", 301)
                .AddRedirect("gallery/colors/belyi.html", "gallery/belyj", 301)
                .AddRedirect("gallery/colors/belyi/page-2.html", "gallery/belyj", 301)
                .AddRedirect("gallery/colors/s_izobrazheniem.html", "gallery/s-izobrazheniem", 301)
                .AddRedirect("gallery/colors/cherno_belyi.html", "gallery/cherno-belyj", 301)
                .AddRedirect("gallery/colors/chernyi.html", "gallery/chernyj", 301)
                .AddRedirect("gallery/colors/s_uzorom.html", "gallery/s-uzorom", 301)
                .AddRedirect("gallery/colors/cvetnoi.html", "gallery/cvetnoj", 301)
                .AddRedirect("gallery/colors/s_risunkom.html", "gallery/s-risunkom", 301)
                .AddRedirect("gallery/trainings.html", "gallery/obuchenie", 301)
                .AddRedirect("gallery/trainings/tehnologia.html", "gallery/tekhnologiya", 301)
                .AddRedirect("on_tv.html", "tv", 301)
                .AddRedirect("on_tv/prozrachnaja_gostinaja.html", "tv/ntv-kvartirnyj-vopros-prozrachnaya-gostinaya", 301)
                .AddRedirect("on_tv/tonizirujuschaja_gostinaja.html", "tv/toniziruyushchaya-gostinaya", 301)
                .AddRedirect("on_tv/gostinaja_pod_rozovoj_pudroj.html", "tv/gostinaya-pod-rozovoj-pudroj", 301)
                .AddRedirect("on_tv/prozrachnaja_gostinaja.html", "tv/prozrachnaya-gostinaya", 301)
                .AddRedirect("on_tv/na_luzhajke_pod_shatrom.html", "tv/na-luzhajke-pod-shatrom", 301)
                .AddRedirect("on_tv/steni.html", "tv/puzyrki-v-okruzhenii-belykh-sten", 301)
                .AddRedirect("on_tv/sokrovish.html", "tv/podzemele-dlya-sokrovishch", 301)
                .AddRedirect("on_tv/reformy_tsveta_i_formy.html", "tv/reformy-cveta-i-formy", 301)
                .AddRedirect("on_tv/sneg.html", "tv/snezhnaya-skazka", 301)
                .AddRedirect("on_tv/chistaya_rabota_cherno_belyi_glianetc.html", "tv/cherno-belyj-glyanec", 301)
                .AddRedirect("on_tv/shkola_remonta_afrikanski_gipnoz.html", "tv/afrikanskij-gipnoz", 301)
                .AddRedirect("on_tv/shkola_remonta_cherno_rozovyj_shok.html", "tv/cherno-rozovyj-shok", 301)
                .AddRedirect("on_tv/kirpich_graffiti_origami.html", "tv/kirpich-graffiti-origami", 301)
                .AddRedirect("on_tv/spalnja_v_elochku.html", "tv/spalnya-v-yolochku", 301)
                .AddRedirect("on_tv/zavtrak_na_trave.html", "tv/zavtrak-na-trave", 301)
                .AddRedirect("on_tv/klab.html", "tv/orkhideologiya-dlya-kamedi-klab", 301)
                .AddRedirect("on_tv/podzemele_dlja_sokrovisch.html", "tv/podzemele-dlya-sokrovishch", 301)
                .AddRedirect("on_tv/dveri_ischezajut_v_polden.html", "tv/dveri-ischezayut-v-polden", 301)
                .AddRedirect("on_tv/gamak_v_ultramarine.html", "tv/gamak-v-ultramarine", 301)
                .AddRedirect("on_tv/stekljannyj_most_i_krysha_naiznanku.html", "tv/steklyannyj-most-i-krysha-naiznanku", 301)
                .AddRedirect("projects.html", "projects", 301)
                .AddRedirect("projects/medvedkovo.html", "projects/nalivnye-poly-ot-poli-floor-v-medvedkovo", 301)
                .AddRedirect("projects/dekorativnye_3d_nalivnye_poly_v_kvartire_v_krasnogorske_.html", "projects/nalivnye-poly-3d-v-g-krasnogorsk", 301)
                .AddRedirect("projects/3d_poly_v_g_krasnogorsk.html", "projects/poly-s-trafaretom-v-g-krasnogorsk", 301)
                .AddRedirect("projects/3d_dno_bassejna.html", "projects/3d-dno-bassejna", 301)
                .AddRedirect("projects/nalivnye_poly_v_g_noginsk_3d_pol_pod_mramor_s_uzorami.html", "projects/nalivnye-poly-v-g-noginsk-3d-pol-pod-mramor-s-uzorami", 301)
                .AddRedirect("projects/polirovannyj-beton-ofis-kompanii-bonduelle.html", "projects/polirovannyj-beton-ofis-kompanii-bonduelle", 301)
                .AddRedirect("projects/polirovannyj-beton-v-muzee-kosmos-na-vdnh.html", "projects/polirovannyj-beton-v-muzee-kosmos-na-vdnkh", 301)
                .AddRedirect("projects/polirovannyj-beton-v-moskva-siti.html", "projects/polirovannyj-beton-v-moskva-siti", 301)
                .AddRedirect("projects/beliy-pol.html", "projects/belyj-dekorativnyj-nalivnoj-pol", 301)
                .AddRedirect("projects/Jiguli.html", "projects/nalivnoj-pol-v-kafe-zhiguli", 301)
                .AddRedirect("projects/promyshlennyj_nalivnoj_pol_v_skutershop.html", "projects/promyshlennyj-nalivnoj-pol-v-skutershop", 301)
                .AddRedirect("projects/3d_poly_v_chastnom_detskom_sadufemeli_clab_u_pugachevoj_ally_borisovny.html", "projects/3d-poly-v-chastnom-detskom-sadufamily-club-u-pugachevoj-alli-borisovni", 301)
                .AddRedirect("projects/epoksidnye_poly_s_trafforetnym_risunkom_v_kofe_haus_aeroport_domodedovo.html", "projects/epoksidnye-poly-s-trafaretnym-risunkom-v-kofe-khaus-aehroport-domodedovo", 301)
                .AddRedirect("video.html", "obuchenie", 301)
                .AddRedirect("calculator.html", "calculator", 301)
                .AddRedirect("contacts.html", "contacts", 301)
                .AddRedirect("faq.html", "faq", 301)
                .AddRedirect("faq/nalivnye_poli.html", "faq/nalivnye-poly", 301)
                .AddRedirect("faq/3d_poli.html", "faq/3d-poly", 301)
                .AddRedirect("faq/vid_pomesheni.html", "faq/vidy-pomeshchenij", 301)
                .AddRedirect("faq/polirovani_beton.html", "faq/terracco", 301)
                .AddRedirect("faq/mikrocement.html", "faq/polimercementnye-poly", 301)
                .AddRedirect("faq/sportivnie_poli.html", "faq/sportivnye-poly", 301)
                .AddRedirect("faq/promyshlennie_poli.html", "faq/promyshlennye-poly", 301)
                .AddRedirect("faq/polimerni_poli.html", "faq/polimernye-poly", 301)
                .AddRedirect("faq/epoksidnie_poli.html", "faq/epoksidnye-poly", 301)
                .AddRedirect("faq/poliuretanovie_poli.html", "faq/poliuretanovye-poly", 301)
                .AddRedirect("faq/decorativnie_poli.html", "faq/dekorativnye-poly", 301)
                .AddRedirect("faq/polirovani_beton/64.html", "faq/kak-polirovat-beton", 301)
                .AddRedirect("faq/mikrocement/65.html", "faq/kak-nanesti-mikrocement", 301)
                .AddRedirect("faq/epoksidnie_poli/66.html", "faq/kakova-tekhnologiya-ehpoksidnykh-polov", 301)
                .AddRedirect("faq/polimerni_poli/68.html", "faq/kak-ustroeny-polimernye-poly", 301)
                .AddRedirect("faq/epoksidnie_poli/67.html", "faq/kak-ustroen-ehpoksidnyj-pol", 301)
                .AddRedirect("faq/sportivnie_poli/63.html", "faq/kak-ustroeny-poly-v-sportivnykh-zalakh", 301)
                .AddRedirect("faq/sportivnie_poli/62.html", "faq/kakova-konstrukciya-sportivnogo-pola", 301)
                .AddRedirect("faq/promyshlennie_poli/61.html", "faq/kak-remontirovat-promyshlennye-poly", 301)
                .AddRedirect("faq/promyshlennie_poli/60.html", "faq/kakova-tekhnologiya-promyshlennykh-polov", 301)
                .AddRedirect("faq/3d_poli/59.html", "faq/kakie-materialy-nuzhny-dlya-3d-pola", 301)
                .AddRedirect("faq/3d_poli/58.html", "faq/kakova-tekhnologiya-3d-polov", 301)
                .AddRedirect("faq/3d_poli/57.html", "faq/obuchenie-zalivke-nalivnykh-3d-polov", 301)
                .AddRedirect("faq/nalivnye_poli/56.html", "faq/skolko-sokhnet-nalivnoj-pol", 301)
                .AddRedirect("faq/nalivnye_poli/55.html", "faq/kakoj-raskhod-nalivnogo-pola-na-kvadratnyj-metr", 301)
                .AddRedirect("faq/nalivnye_poli/54.html", "faq/kak-sdelat-nalivnoj-pol", 301)
                .AddRedirect("faq/nalivnye_poli/46.html", "faq/nalivaem-poly-kriterii-vybora-i-vse-o-nalivnykh-polakh", 301)
                .AddRedirect("faq/poliuretanovie_poli/40.html", "faq/poliuretanovyj-nalivnoj-pol", 301)
                .AddRedirect("faq/3d_poli/37.html", "faq/gde-mozhno-ispolzovat-nalivnoj-3d-pol", 301)
                .AddRedirect("faq/vid_pomesheni/45.html", "faq/poly-v-butikakh", 301)
                .AddRedirect("faq/vid_pomesheni/42.html", "faq/poly-v-ofisakh", 301)
                .AddRedirect("faq/decorativnie_poli/44.html", "faq/dekorativnye-nalivnye-poly-novoe-slovo-v-dizajnerskom-remonte", 301)
                .AddRedirect("faq/nalivnye_poli/43.html", "faq/nalivnoj-pol-prochnost-i-dolgovechnost", 301)
                .AddRedirect("faq/nalivnye_poli/41.html", "faq/zhidkie-nalivnye-poly", 301)
                .AddRedirect("faq/nalivnye_poli/36.html", "faq/poly-nalivnye-chto-ehto", 301)
                .AddRedirect("faq/nalivnye_poli/38.html", "faq/roskosh-li-dekorativnyj-nalivnoj-pol", 301)
                .AddRedirect("faq/nalivnye_poli/33.html", "faq/nalivnye-poly-v-kvartirah-vozmozhno-li", 301)
                .AddRedirect("faq/nalivnye_poli/30.html", "faq/zhidkie-poly-kak-ehksklyuziv", 301)
                .AddRedirect("faq/nalivnye_poli/29.html", "faq/nemnogo-o-nalivnyh-polah", 301)
                .AddRedirect("faq/nalivnye_poli/31.html", "faq/zalivnye-poly-v-chem-preimushchestvo", 301)
                .AddRedirect("faq/epoksidnie_poli/39.html", "faq/epoksidnyj-nalivnoj-pol", 301)
                .AddRedirect("faq/nalivnye_poli/34.html", "faq/pravilnyj-ukhod-za-nalivnymi-polami", 301)
                .AddRedirect("faq/nalivnye_poli/35.html", "faq/vybiraem-nalivnoj-pol", 301)
                .AddRedirect("faq/vid_pomesheni/32.html", "faq/nalivnoj-pol-v-garazhe", 301)
                .AddRedirect("news.html", "news", 301)
                .AddRedirect("news/47.html", "news/smotrite-2", 301)
                .AddRedirect("news/20.html", "news/obuchenie-nalivnym-polam-3d", 301)
                .AddRedirect("news/5.html", "news/vnimanie!!!-pervij-obuchayushchij-seminar-na-ukraine", 301)
                .AddRedirect("news/4.html", "news/poli-floor-v-podzemele-dlya-sokrovishch", 301)
                .AddRedirect("news/25.html", "news/2-marta-poli-floor-na-telekanale-ntv!", 301)
                .AddRedirect("news/17.html", "news/poli-floor-na-tnt", 301)
                .AddRedirect("news/17.html", "news/poli-floor-na-tnt", 301)
                .AddRedirect("news/18.html", "news/poli-floor-v-predache-dachnyj-otvet", 301)
                .AddRedirect("news/26.html", "news/poli-floor-na-kanale-ren-tv", 301)
                .AddRedirect("dealers/kaluga.html", "dealers/kaluga", 301)
                .AddRedirect("dealers/kurskaya_oblast.html", "dealers/kursk", 301)
                .AddRedirect("dealers/vladimirskaia.html", "dealers/kovrov", 301)
                .AddRedirect("dealers/tver.html", "dealers/tver", 301)
                .AddRedirect("dealers/ryazan.html", "dealers/ryazan", 301)
                .AddRedirect("dealers/voronezh.html", "dealers/voronezh", 301)
                .AddRedirect("dealers/kimri_kimri.html", "dealers/kimry", 301)
                .AddRedirect("dealers/borovsk_borovsk.html", "dealers/borovsk", 301)
                .AddRedirect("dealers/g_lipetsk.html", "dealers/lipeck", 301)
                .AddRedirect("dealers/vladimir.html", "dealers/vladimir", 301)
                .AddRedirect("dealers/g_dmitrov.html", "dealers/dmitrov", 301)
                .AddRedirect("dealers/myrom_d.html", "dealers/murom", 301)
                .AddRedirect("dealers/g_klin.html", "dealers/klin", 301)
                .AddRedirect("dealers/g_orexovo-zuevo.html", "dealers/orekhovo-zuevo", 301)
                .AddRedirect("dealers/g_podolsk.html", "dealers/podolsk", 301)
                .AddRedirect("dealers/g_suzdal.html", "dealers/suzdal", 301)
                .AddRedirect("dealers/stariyoskol.html", "dealers/staryj-oskol", 301)
                .AddRedirect("dealers/piter.html", "dealers/sankt-peterburg", 301)
                .AddRedirect("dealers/murmanskaya_oblast.html", "dealers/murmansk", 301)
                .AddRedirect("dealers/carel_s.html", "dealers/petrozavodsk", 301)
                .AddRedirect("dealers/cherepovetsk.html", "dealers/cherepovec", 301)
                .AddRedirect("dealers/g_arhangelsk.html", "dealers/arkhangelsk", 301)
                .AddRedirect("dealers/siktivka_r.html", "dealers/syktyvkar", 301)
                .AddRedirect("dealers/g_pechora.html", "dealers/pechora", 301)
                .AddRedirect("dealers/rostov-na-donu.html", "dealers/rostov-na-donu", 301)
                .AddRedirect("dealers/belorechensk.html", "dealers/belorechensk", 301)
                .AddRedirect("dealers/timashevsk.html", "dealers/timashevsk", 301)
                .AddRedirect("dealers/astrahan.html", "dealers/astrakhan", 301)
                .AddRedirect("dealers/krasnodar.html", "dealers/krasnodar", 301)
                .AddRedirect("dealers/g_armavir.html", "dealers/armavir", 301)
                .AddRedirect("dealers/dagestan.html", "dealers/makhachkala", 301)
                .AddRedirect("dealers/gudermes.html", "dealers/gudermes", 301)
                .AddRedirect("dealers/chechen_grozn.html", "dealers/groznyj", 301)
                .AddRedirect("dealers/vladikavkaz.html", "dealers/vladikavkaz", 301)
                .AddRedirect("dealers/penza.html", "dealers/penza", 301)
                .AddRedirect("dealers/saransk.html", "dealers/saransk", 301)
                .AddRedirect("dealers/cheboksari.html", "dealers/cheboksary", 301)
                .AddRedirect("dealers/buzuluk.html", "dealers/buzuluk", 301)
                .AddRedirect("dealers/neftek.html", "dealers/neftekamsk", 301)
                .AddRedirect("dealers/naberejn.html", "dealers/naberezhnye-chelny", 301)
                .AddRedirect("dealers/ulianovsk.html", "dealers/ulyanovsk", 301)
                .AddRedirect("dealers/ilek.html", "dealers/orenburgskaya-obl-s-ilek", 301)
                .AddRedirect("dealers/saratov.html", "dealers/saratov", 301)
                .AddRedirect("dealers/perm_p.html", "dealers/perm", 301)
                .AddRedirect("dealers/kirov_ip.html", "dealers/kirov", 301)
                .AddRedirect("dealers/g_nijniy-lomov.html", "dealers/nizhnii-lomov", 301)
                .AddRedirect("dealers/g_orenburg.html", "dealers/orenburg", 301)
                .AddRedirect("dealers/novosidirs_k.html", "dealers/novosibirsk", 301)
                .AddRedirect("dealers/kurgan.html", "dealers/kurgan", 301)
                .AddRedirect("dealers/kachkanar.html", "dealers/kachkanar", 301)
                .AddRedirect("dealers/nijnevartovsk.html", "dealers/nizhnevartovsk", 301)
                .AddRedirect("dealers/omsk.html", "dealers/omsk", 301)
                .AddRedirect("dealers/bratsk.html", "dealers/bratsk", 301)
                .AddRedirect("dealers/irkutsk.html", "dealers/irkutsk", 301)
                .AddRedirect("dealers/miass.html", "dealers/miass-chelyabinskaya-obl", 301)
                .AddRedirect("dealers/krasnoyrsk.html", "dealers/krasnoyarsk", 301)
                .AddRedirect("dealers/novokuzneck.html", "dealers/novokuzneck", 301)
                .AddRedirect("dealers/vladivostok.html", "dealers/vladivostok", 301)
                .AddRedirect("dealers/magadan.html", "dealers/magadan", 301)
                .AddRedirect("dealers/habarovsk.html", "dealers/khabarovsk", 301)
                .AddRedirect("dealers/artem.html", "dealers/artem", 301)
                .AddRedirect("dealers/nahodka.html", "dealers/nakhodka", 301)
                .AddRedirect("dealers/yakutsk.html", "dealers/yakutsk", 301)
                .AddRedirect("dealers/komsamur.html", "dealers/komsomolsk-na-amure", 301)
                .AddRedirect("dealers/partizansk.html", "dealers/partizansk", 301)
                .AddRedirect("dealers/ani_va.html", "dealers/aniva", 301)
                .AddRedirect("dealers/yssy_risk.html", "dealers/ussurijsk", 301)
                .AddRedirect("dealers/g_korsakov.html", "dealers/korsakov", 301)
                .AddRedirect("dealers/ptropavlovsk-kamchatskiy.html", "dealers/petropavlovsk-kamchatskij", 301)
                .AddRedirect("dealers/telaviv.html", "dealers/tel-aviv-izrail", 301)
                .AddRedirect("dealers/france.html", "dealers/franciya", 301)
                .AddRedirect("dealers/finland.html", "dealers/finlyandiya", 301)
                .AddRedirect("dealers/avstria_gratz.html", "dealers/grac-avstriya", 301)
                .AddRedirect("dealers/tomka-1975.html", "dealers/atyrau", 301)
                .AddRedirect("dealers/litva_01.html", "dealers/litva", 301)
                .AddRedirect("dealers/estoniya.html", "dealers/tallin-estoniya", 301)
                .AddRedirect("dealers/almati.html", "dealers/almaty", 301)
                .AddRedirect("dealers/bishkek.html", "dealers/bishkek-kyrgyzstan", 301)
                .AddRedirect("gallery/page-2.html", "gallery", 301)
                .AddRedirect("gallery/page-3.html", "gallery", 301)
                .AddRedirect("gallery/page-4.html", "gallery", 301)
                .AddRedirect("gallery/page-5.html", "gallery", 301)
                .AddRedirect("gallery/page-6.html", "gallery", 301)
                .AddRedirect("gallery/page-7.html", "gallery", 301)
                .AddRedirect("gallery/page-8.html", "gallery", 301)
                .AddRedirect("gallery/page-9.html", "gallery", 301)
                .AddRedirect("gallery/page-10.html", "gallery", 301)
                .AddRedirect("gallery/coatings/3d_poli/page-2.html", "gallery/3d-poly", 301)
                .AddRedirect("gallery/coatings/3d_poli/page-3.html", "gallery/3d-poly", 301)
                .AddRedirect("gallery/coatings/3d_poli/page-4.html", "gallery/3d-poly", 301)
                .AddRedirect("gallery/coatings/odnot_poli/page-2.html", "gallery/epoksidnye-poly", 301)
                .AddRedirect("gallery/coatings/odnot_poli/page-3.html", "gallery/epoksidnye-poly", 301)
                .AddRedirect("gallery/rooms/v_komnate/page-2.html", "gallery/v-komnate", 301)
                .AddRedirect("gallery/rooms/v_kvartire/page-2.html", "gallery/v-kvartire", 301)
                .AddRedirect("gallery/rooms/v_kvartire/page-3.html", "gallery/v-kvartire", 301)
                .AddRedirect("gallery/rooms/v_kvartire/page-4.html", "gallery/v-kvartire", 301)
                .AddRedirect("gallery/rooms/v_dome/page-2.html", "gallery/v-dome", 301)
                .AddRedirect("gallery/rooms/v_dome/page-3.html", "gallery/v-dome", 301)
                .AddRedirect("gallery/colors/s_izobrazheniem/page-2.html", "gallery/s-izobrazheniem", 301)
                .AddRedirect("gallery/colors/belyi/page-2.html", "gallery/belyj", 301)
                .AddRedirect("gallery/colors/s_uzorom/page-2.html", "gallery/s-uzorom", 301)
                .AddRedirect("gallery/colors/cvetnoi/page-2.html", "gallery/cvetnoj", 301)
                .AddRedirect("gallery/colors/s_risunkom/page-2.html", "gallery/s-risunkom", 301)
                .AddRedirect("gallery/colors/s_risunkom/page-3.html", "gallery/s-risunkom", 301)
                .AddRedirect("polirovanni_beton.html", "polimercement", 301)
                .AddRedirect("mikrocement.html", "polimercement", 301)
                .AddRedirect("gallery/terracco", "gallery/terrazzo", 301)
                .AddRedirect("sportivnoe-pokrytie", "poimernye-poly", 301)
                .AddRedirect("terracco", "terrazzo", 301);

            options.AddRedirectToHttps(301);
            options.AddRedirectToWww(301);

            app.UseRewriter(options);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas-pagination",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{page?}"
                );

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
