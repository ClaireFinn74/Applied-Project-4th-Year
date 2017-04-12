using _4thYearAppliedProject;
using _4thYearAppliedProject.AttentionLevels.Total_Recall;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear.AttentionLevels
{
    /// <summary>
    /// an empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TotalRecall : Page
    {
        public TotalRecall()
        {
            GlobalClassVariables.gameName = "(Total Recall Score) " + "\n";
            this.InitializeComponent();
            DispatcherTimerSetup();
        }
   
        DispatcherTimer dispatcherTimer;
        int timesTicked = 180; //3 minutes
        int timesToTick = 180;

        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        async void dispatcherTimer_Tick(object sender, object e)
        {
            txtLog.Text = timesTicked.ToString();
            if (timesTicked > timesToTick)
            {
                txtTimer.Text = "Calling dispatcherTimer.Stop()\n";
                dispatcherTimer.Stop();
                txtTimer.Text = "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
            }
            timesTicked--;

            if (timesTicked == -1)
            {
                dispatcherTimer.Stop();
                var dialog = new MessageDialog("Out of time! You scored:"
                                       + GlobalClassVariables.score);
                var result = await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private void TimerStart_Click_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup();
        }

        private void TimerStop_Click_1(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtTimer.Text = "dispatcherTimer.IsEnabled = False";
        }

        
        public void Dictionary()
        {
            Dictionary<string, int> WordsWithAc = new Dictionary<string, int>();
            WordsWithAc.Add("e", 1); WordsWithAc.Add("t", 2); WordsWithAc.Add("ed", 3); WordsWithAc.Add("es", 4);
            WordsWithAc.Add("he", 5); WordsWithAc.Add("hy", 6); WordsWithAc.Add("id", 7); WordsWithAc.Add("me", 8);
            WordsWithAc.Add("ne", 9); WordsWithAc.Add("re", 10); WordsWithAc.Add("ta", 11); WordsWithAc.Add("ts", 12);
            WordsWithAc.Add("yl", 13); WordsWithAc.Add("ari", 14); WordsWithAc.Add("erb", 15); WordsWithAc.Add("eta", 16);
            WordsWithAc.Add("hed", 17); WordsWithAc.Add("hes", 18); WordsWithAc.Add("hoo", 19); WordsWithAc.Add("ids", 20);
            WordsWithAc.Add("idy", 21); WordsWithAc.Add("ing", 22); WordsWithAc.Add("ini", 23); WordsWithAc.Add("kee", 24);
            WordsWithAc.Add("mes", 25); WordsWithAc.Add("mic", 26); WordsWithAc.Add("ned", 27); WordsWithAc.Add("nes", 28);
            WordsWithAc.Add("ock", 29); WordsWithAc.Add("old", 30); WordsWithAc.Add("orn", 31); WordsWithAc.Add("red", 32);
            WordsWithAc.Add("res", 33); WordsWithAc.Add("rid", 34); WordsWithAc.Add("ted", 35); WordsWithAc.Add("tin", 36);
            WordsWithAc.Add("tor", 37); WordsWithAc.Add("ute", 38); WordsWithAc.Add("yls", 39); WordsWithAc.Add("ia", 40);
            WordsWithAc.Add("ajou", 41); WordsWithAc.Add("arid", 42); WordsWithAc.Add("arus", 43); WordsWithAc.Add("cede", 44);
            WordsWithAc.Add("cent", 45); WordsWithAc.Add("cept", 46); WordsWithAc.Add("cess", 47); WordsWithAc.Add("cord", 48);
            WordsWithAc.Add("cost", 49); WordsWithAc.Add("crue", 50); WordsWithAc.Add("cuse", 51); WordsWithAc.Add("edia", 52);
            WordsWithAc.Add("etal", 53); WordsWithAc.Add("etic", 54); WordsWithAc.Add("etin", 55); WordsWithAc.Add("etum", 56);
            WordsWithAc.Add("etyl", 57); WordsWithAc.Add("hene", 58); WordsWithAc.Add("hier", 59); WordsWithAc.Add("hing", 60);
            WordsWithAc.Add("idic", 61); WordsWithAc.Add("idly", 62); WordsWithAc.Add("inar", 63); WordsWithAc.Add("inic", 64);
            WordsWithAc.Add("inus", 65); WordsWithAc.Add("kees", 66); WordsWithAc.Add("node", 67); WordsWithAc.Add("orns", 68);
            WordsWithAc.Add("quit", 69); WordsWithAc.Add("ross", 70); WordsWithAc.Add("ting", 71); WordsWithAc.Add("tins", 72);
            WordsWithAc.Add("tion", 73); WordsWithAc.Add("tive", 74); WordsWithAc.Add("tors", 75); WordsWithAc.Add("tual", 76);
            WordsWithAc.Add("uate", 77); WordsWithAc.Add("uity", 78); WordsWithAc.Add("ulei", 79); WordsWithAc.Add("umen", 80);
            WordsWithAc.Add("uter", 81); WordsWithAc.Add("utes", 82); WordsWithAc.Add("ias", 83); WordsWithAc.Add("ademe", 84);
            WordsWithAc.Add("ademy", 85); WordsWithAc.Add("ajous", 86); WordsWithAc.Add("aleph", 87); WordsWithAc.Add("antha", 88);
            WordsWithAc.Add("anthi", 89); WordsWithAc.Add("apnia", 90); WordsWithAc.Add("arids", 91); WordsWithAc.Add("arine", 92);
            WordsWithAc.Add("aroid", 93); WordsWithAc.Add("audal", 94); WordsWithAc.Add("ceded", 95); WordsWithAc.Add("ceder", 96);
            WordsWithAc.Add("cents", 97); WordsWithAc.Add("cepts", 98); WordsWithAc.Add("cidia", 99); WordsWithAc.Add("cidie", 100);
            WordsWithAc.Add("claim", 101); WordsWithAc.Add("cords", 102); WordsWithAc.Add("costs", 103); WordsWithAc.Add("count", 104);
            WordsWithAc.Add("crete", 105); WordsWithAc.Add("crual", 106); WordsWithAc.Add("crued", 107); WordsWithAc.Add("crues", 108);
            WordsWithAc.Add("curst", 109); WordsWithAc.Add("cusal", 110); WordsWithAc.Add("cused", 111); WordsWithAc.Add("cuser", 112);
            WordsWithAc.Add("cuses", 113); WordsWithAc.Add("edias", 114); WordsWithAc.Add("equia", 115); WordsWithAc.Add("erate", 116);
            WordsWithAc.Add("erber", 117); WordsWithAc.Add("erbic", 118); WordsWithAc.Add("erola", 119); WordsWithAc.Add("erose", 120);
            WordsWithAc.Add("erous", 121); WordsWithAc.Add("etals", 122); WordsWithAc.Add("etate", 123); WordsWithAc.Add("etify", 124);
            WordsWithAc.Add("etins", 125); WordsWithAc.Add("etone", 126); WordsWithAc.Add("etose", 127); WordsWithAc.Add("etous", 128);
            WordsWithAc.Add("etyls", 129); WordsWithAc.Add("henes", 130); WordsWithAc.Add("hiest", 131); WordsWithAc.Add("hieve", 132);
            WordsWithAc.Add("hiote", 133); WordsWithAc.Add("hiral", 134); WordsWithAc.Add("holia", 135); WordsWithAc.Add("icula", 136);
            WordsWithAc.Add("idify", 137); WordsWithAc.Add("idity", 138); WordsWithAc.Add("iform", 139); WordsWithAc.Add("inous", 140);
            WordsWithAc.Add("linic", 141); WordsWithAc.Add("matic", 142); WordsWithAc.Add("nodes", 143); WordsWithAc.Add("olyte", 144);
            WordsWithAc.Add("onite", 145); WordsWithAc.Add("orned", 146); WordsWithAc.Add("quest", 147); WordsWithAc.Add("quire", 148);
            WordsWithAc.Add("quits", 149); WordsWithAc.Add("rasia", 150); WordsWithAc.Add("rasin", 151); WordsWithAc.Add("reage", 152);
            WordsWithAc.Add("rider", 153); WordsWithAc.Add("ridly", 154); WordsWithAc.Add("robat", 155); WordsWithAc.Add("rogen", 156);
            WordsWithAc.Add("romia", 157); WordsWithAc.Add("ronic", 158); WordsWithAc.Add("ronym", 159); WordsWithAc.Add("rotic", 160);
            WordsWithAc.Add("rylic", 161); WordsWithAc.Add("table", 162); WordsWithAc.Add("tinal", 163); WordsWithAc.Add("tings", 164);
            WordsWithAc.Add("tinia", 165); WordsWithAc.Add("tinic", 166); WordsWithAc.Add("tinon", 167); WordsWithAc.Add("tions", 168);
            WordsWithAc.Add("tives", 169); WordsWithAc.Add("torly", 170); WordsWithAc.Add("tress", 171); WordsWithAc.Add("tuate", 172);
            WordsWithAc.Add("uleus", 173); WordsWithAc.Add("umens", 174); WordsWithAc.Add("utely", 175); WordsWithAc.Add("utest", 176);
            WordsWithAc.Add("yclic", 177); WordsWithAc.Add("ylate", 178); WordsWithAc.Add("yloin", 179); WordsWithAc.Add("ademes", 180);
            WordsWithAc.Add("ademia", 181); WordsWithAc.Add("ademic", 182); WordsWithAc.Add("alephe", 183); WordsWithAc.Add("alephs", 184);
            WordsWithAc.Add("anthae", 185); WordsWithAc.Add("anthus", 186); WordsWithAc.Add("apnias", 187); WordsWithAc.Add("arbose", 188);
            WordsWithAc.Add("aridan", 189); WordsWithAc.Add("arines", 190); WordsWithAc.Add("arpous", 191); WordsWithAc.Add("audate", 192);
            WordsWithAc.Add("auline", 193); WordsWithAc.Add("aulose", 194); WordsWithAc.Add("aulous", 195); WordsWithAc.Add("ceders", 196);
            WordsWithAc.Add("ceding", 197); WordsWithAc.Add("cented", 198); WordsWithAc.Add("centor", 199); WordsWithAc.Add("cepted", 200);
            WordsWithAc.Add("ceptee", 201); WordsWithAc.Add("cepter", 202); WordsWithAc.Add("ceptor", 203); WordsWithAc.Add("cessed", 204);
            WordsWithAc.Add("cesses", 205); WordsWithAc.Add("cident", 206); WordsWithAc.Add("cidias", 207); WordsWithAc.Add("cidies", 208);
            WordsWithAc.Add("claims", 209); WordsWithAc.Add("colade", 210); WordsWithAc.Add("corded", 211); WordsWithAc.Add("corder", 212);
            WordsWithAc.Add("costed", 213); WordsWithAc.Add("counts", 214); WordsWithAc.Add("couter", 215); WordsWithAc.Add("coutre", 216);
            WordsWithAc.Add("credit", 217); WordsWithAc.Add("creted", 218); WordsWithAc.Add("cretes", 219); WordsWithAc.Add("cruals", 220);
            WordsWithAc.Add("cruing", 221); WordsWithAc.Add("curacy", 222); WordsWithAc.Add("curate", 223); WordsWithAc.Add("cursed", 224);
            WordsWithAc.Add("cusals", 225); WordsWithAc.Add("cusant", 226); WordsWithAc.Add("cusers", 227); WordsWithAc.Add("cusing", 228);
            WordsWithAc.Add("custom", 229); WordsWithAc.Add("eldama", 230); WordsWithAc.Add("entric", 231); WordsWithAc.Add("equias", 232);
            WordsWithAc.Add("erated", 233); WordsWithAc.Add("erbate", 234); WordsWithAc.Add("erbest", 235); WordsWithAc.Add("erbity", 236);
            WordsWithAc.Add("erolas", 237); WordsWithAc.Add("ervate", 238); WordsWithAc.Add("ervuli", 239); WordsWithAc.Add("escent", 240);
            WordsWithAc.Add("etamid", 241); WordsWithAc.Add("etated", 242); WordsWithAc.Add("etates", 243); WordsWithAc.Add("etones", 244);
            WordsWithAc.Add("etonic", 245); WordsWithAc.Add("etoxyl", 246); WordsWithAc.Add("etylic", 247); WordsWithAc.Add("henial", 248);
            WordsWithAc.Add("hieved", 249); WordsWithAc.Add("hiever", 250); WordsWithAc.Add("hieves", 251); WordsWithAc.Add("hillea", 252);
            WordsWithAc.Add("hiness", 253); WordsWithAc.Add("hingly", 254); WordsWithAc.Add("hiotes", 255); WordsWithAc.Add("holias", 256);
            WordsWithAc.Add("hromat", 257); WordsWithAc.Add("hromic", 258); WordsWithAc.Add("iculae", 259); WordsWithAc.Add("icular", 260);
            WordsWithAc.Add("iculas", 261); WordsWithAc.Add("iculum", 262); WordsWithAc.Add("idemia", 263); WordsWithAc.Add("idhead", 264);
            WordsWithAc.Add("idness", 265); WordsWithAc.Add("idoses", 266); WordsWithAc.Add("idosis", 267); WordsWithAc.Add("idotic", 268);
            WordsWithAc.Add("iduria", 269); WordsWithAc.Add("ierate", 270); WordsWithAc.Add("oelous", 271); WordsWithAc.Add("olytes", 272);
            WordsWithAc.Add("onites", 273); WordsWithAc.Add("onitic", 274); WordsWithAc.Add("onitum", 275); WordsWithAc.Add("oustic", 276);
            WordsWithAc.Add("quaint", 277); WordsWithAc.Add("quests", 278); WordsWithAc.Add("quired", 279); WordsWithAc.Add("quiree", 280);
            WordsWithAc.Add("quirer", 281); WordsWithAc.Add("quires", 282); WordsWithAc.Add("rasias", 283); WordsWithAc.Add("rasins", 284);
            WordsWithAc.Add("reages", 285); WordsWithAc.Add("ridest", 286); WordsWithAc.Add("ridine", 287); WordsWithAc.Add("ridity", 288);
            WordsWithAc.Add("rimony", 289); WordsWithAc.Add("robats", 290); WordsWithAc.Add("rodont", 291); WordsWithAc.Add("rogens", 292);
            WordsWithAc.Add("rolect", 293); WordsWithAc.Add("rolein", 294); WordsWithAc.Add("rolith", 295); WordsWithAc.Add("romial", 296);
            WordsWithAc.Add("romion", 297); WordsWithAc.Add("ronyms", 298); WordsWithAc.Add("rosome", 299); WordsWithAc.Add("rostic", 300);
            WordsWithAc.Add("rotism", 301); WordsWithAc.Add("rylate", 302); WordsWithAc.Add("rylics", 303); WordsWithAc.Add("tiniae", 304);
            WordsWithAc.Add("tinian", 305); WordsWithAc.Add("tinias", 306); WordsWithAc.Add("tinide", 307); WordsWithAc.Add("tinism", 308);
            WordsWithAc.Add("tinium", 309); WordsWithAc.Add("tinoid", 310); WordsWithAc.Add("tinons", 311); WordsWithAc.Add("tioner", 312);
            WordsWithAc.Add("tivate", 313); WordsWithAc.Add("tively", 314); WordsWithAc.Add("tivism", 315); WordsWithAc.Add("tivist", 316);
            WordsWithAc.Add("tivity", 317); WordsWithAc.Add("tivize", 318); WordsWithAc.Add("torish", 319); WordsWithAc.Add("tressy", 320);
            WordsWithAc.Add("tually", 321); WordsWithAc.Add("tuated", 322); WordsWithAc.Add("tuates", 323); WordsWithAc.Add("tuator", 324);
            WordsWithAc.Add("uities", 325); WordsWithAc.Add("uleate", 326); WordsWithAc.Add("utance", 327); WordsWithAc.Add("ylated", 328);
            WordsWithAc.Add("ylates", 329); WordsWithAc.Add("yloins", 330); WordsWithAc.Add("ademias", 331); WordsWithAc.Add("ademics", 332);
            WordsWithAc.Add("ademies", 333); WordsWithAc.Add("ademism", 334); WordsWithAc.Add("alephae", 335); WordsWithAc.Add("alephes", 336);
            WordsWithAc.Add("anthine", 337); WordsWithAc.Add("anthoid", 338); WordsWithAc.Add("anthous", 339); WordsWithAc.Add("arboses", 340);
            WordsWithAc.Add("ariases", 341); WordsWithAc.Add("ariasis", 342); WordsWithAc.Add("aricide", 343); WordsWithAc.Add("aridans", 344);
            WordsWithAc.Add("arology", 345); WordsWithAc.Add("cedence", 346); WordsWithAc.Add("centing", 347); WordsWithAc.Add("centors", 348);
            WordsWithAc.Add("centual", 349); WordsWithAc.Add("ceptant", 350); WordsWithAc.Add("ceptees", 351); WordsWithAc.Add("cepters", 352);
            WordsWithAc.Add("cepting", 353); WordsWithAc.Add("ceptive", 354); WordsWithAc.Add("ceptors", 355); WordsWithAc.Add("cessary", 356);
            WordsWithAc.Add("cessing", 357); WordsWithAc.Add("cession", 358); WordsWithAc.Add("cessory", 359); WordsWithAc.Add("cidence", 360);
            WordsWithAc.Add("cidents", 361); WordsWithAc.Add("cipiter", 362); WordsWithAc.Add("claimed", 363); WordsWithAc.Add("claimer", 364);
            WordsWithAc.Add("climate", 365); WordsWithAc.Add("clivity", 366); WordsWithAc.Add("clivous", 367); WordsWithAc.Add("coladed", 368);
            WordsWithAc.Add("colades", 369); WordsWithAc.Add("company", 370); WordsWithAc.Add("cordant", 371); WordsWithAc.Add("corders", 372);
            WordsWithAc.Add("cording", 373); WordsWithAc.Add("cordion", 374); WordsWithAc.Add("costing", 375); WordsWithAc.Add("counted", 376);
            WordsWithAc.Add("couters", 377); WordsWithAc.Add("coutred", 378); WordsWithAc.Add("coutres", 379); WordsWithAc.Add("credits", 380);
            WordsWithAc.Add("creting", 381); WordsWithAc.Add("cretion", 382); WordsWithAc.Add("cretive", 383); WordsWithAc.Add("cruable", 384);
            WordsWithAc.Add("cumbent", 385); WordsWithAc.Add("cusable", 386); WordsWithAc.Add("cusably", 387); WordsWithAc.Add("cusants", 388);
            WordsWithAc.Add("customs", 389); WordsWithAc.Add("eldamas", 390); WordsWithAc.Add("ellular", 391); WordsWithAc.Add("ephalic", 392);
            WordsWithAc.Add("erbated", 393); WordsWithAc.Add("erbates", 394); WordsWithAc.Add("ervulus", 395); WordsWithAc.Add("escents", 396);
            WordsWithAc.Add("etabula", 397); WordsWithAc.Add("etamide", 398); WordsWithAc.Add("etamids", 399); WordsWithAc.Add("etified", 400);
            WordsWithAc.Add("etifier", 401); WordsWithAc.Add("etifies", 402); WordsWithAc.Add("etoxyls", 403); WordsWithAc.Add("etylate", 404);
            WordsWithAc.Add("etylene", 405); WordsWithAc.Add("halasia", 406); WordsWithAc.Add("hievers", 407); WordsWithAc.Add("hieving", 408);
            WordsWithAc.Add("hilleas", 409); WordsWithAc.Add("hromats", 410); WordsWithAc.Add("hromous", 411); WordsWithAc.Add("iculate", 412);
            WordsWithAc.Add("iculums", 413); WordsWithAc.Add("idemias", 414); WordsWithAc.Add("idheads", 415); WordsWithAc.Add("idified", 416);
            WordsWithAc.Add("idifier", 417); WordsWithAc.Add("idifies", 418); WordsWithAc.Add("idities", 419); WordsWithAc.Add("idophil", 420);
            WordsWithAc.Add("idulate", 421); WordsWithAc.Add("idulent", 422); WordsWithAc.Add("idulous", 423); WordsWithAc.Add("idurias", 424);
            WordsWithAc.Add("ierated", 425); WordsWithAc.Add("ierates", 426); WordsWithAc.Add("iniform", 427); WordsWithAc.Add("onitums", 428);
            WordsWithAc.Add("oustics", 429); WordsWithAc.Add("quaints", 430); WordsWithAc.Add("quiesce", 431); WordsWithAc.Add("quirees", 432);
            WordsWithAc.Add("quirers", 433); WordsWithAc.Add("quiring", 434); WordsWithAc.Add("quittal", 435); WordsWithAc.Add("quitted", 436);
            WordsWithAc.Add("quitter", 437); WordsWithAc.Add("ridines", 438); WordsWithAc.Add("ridness", 439); WordsWithAc.Add("ritarch", 440);
            WordsWithAc.Add("ritical", 441); WordsWithAc.Add("robatic", 442); WordsWithAc.Add("rodonts", 443); WordsWithAc.Add("rogenic", 444);
            WordsWithAc.Add("rolects", 445); WordsWithAc.Add("roleins", 446); WordsWithAc.Add("roliths", 447); WordsWithAc.Add("ronical", 448);
            WordsWithAc.Add("ronycal", 449); WordsWithAc.Add("ronymic", 450); WordsWithAc.Add("ropetal", 451); WordsWithAc.Add("rophobe", 452);
            WordsWithAc.Add("ropolis", 453); WordsWithAc.Add("rosomal", 454); WordsWithAc.Add("rosomes", 455); WordsWithAc.Add("rospire", 456);
            WordsWithAc.Add("rostics", 457); WordsWithAc.Add("rotisms", 458); WordsWithAc.Add("rylates", 459); WordsWithAc.Add("tinally", 460);
            WordsWithAc.Add("tinians", 461); WordsWithAc.Add("tinides", 462); WordsWithAc.Add("tinisms", 463); WordsWithAc.Add("tiniums", 464);
            WordsWithAc.Add("tinoids", 465); WordsWithAc.Add("tioners", 466); WordsWithAc.Add("tivated", 467); WordsWithAc.Add("tivates", 468);
            WordsWithAc.Add("tivator", 469); WordsWithAc.Add("tivisms", 470); WordsWithAc.Add("tivists", 471); WordsWithAc.Add("tivized", 472);
            WordsWithAc.Add("tivizes", 473); WordsWithAc.Add("tresses", 474); WordsWithAc.Add("tuality", 475); WordsWithAc.Add("tualize", 476);
            WordsWithAc.Add("tuarial", 477); WordsWithAc.Add("tuaries", 478); WordsWithAc.Add("tuating", 479); WordsWithAc.Add("tuation", 480);
            WordsWithAc.Add("tuators", 481); WordsWithAc.Add("uleated", 482); WordsWithAc.Add("uminate", 483); WordsWithAc.Add("uminous", 484);
            WordsWithAc.Add("utances", 485); WordsWithAc.Add("uteness", 486); WordsWithAc.Add("yclovir", 487); WordsWithAc.Add("ylating", 488);
            WordsWithAc.Add("ylation", 489);

            try
            {
                if (WordsWithAc.ContainsKey(txtUserInput.Text))
                {
                    WordsWithAc.Remove(txtUserInput.Text);
                    GlobalClassVariables.score += 10;
                    txtScore.Text = GlobalClassVariables.score.ToString();
                    imgCorrectSign.Visibility = Visibility.Visible;
                    imgX.Visibility = Visibility.Collapsed;
                }
                else
                {
                    imgX.Visibility = Visibility.Visible;
                    imgCorrectSign.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            Dictionary();
            if (GlobalClassVariables.score >= 150)
            {
                btnLevel2.Visibility = Visibility.Visible;
            }
        }

        private void btnLevel2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TotalRecallLevel2));
        }
    }
    }
