using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Data;
using System.IO;
using System.Net;

public class GStatsGoalieRating06 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating06 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating06 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating06.Add("Lukas Dostal","Save, to RW");
PlayerGStatsGoalieRating06.Add("John Gibson","Save, to RW");
PlayerGStatsGoalieRating06.Add("Thomas Hodges","Save, to LD");
PlayerGStatsGoalieRating06.Add("Anthony Stolarz","Save, to LD");
PlayerGStatsGoalieRating06.Add("Josef Korenar","Goal");
PlayerGStatsGoalieRating06.Add("Ivan Prosvetov","Rebound");
PlayerGStatsGoalieRating06.Add("Harri Sateri","Goal");
PlayerGStatsGoalieRating06.Add("Karel Vejmelka","Save, to LD");
PlayerGStatsGoalieRating06.Add("Troy Grosenick","Save, to RD");
PlayerGStatsGoalieRating06.Add("Jeremy Swayman","Save, to RW");
PlayerGStatsGoalieRating06.Add("Linus Ullmark","Penalty");
PlayerGStatsGoalieRating06.Add("Craig Anderson","Save, to Any");
PlayerGStatsGoalieRating06.Add("Eric Comrie","Save, to Any");
PlayerGStatsGoalieRating06.Add("Michael Houser","Rebound");
PlayerGStatsGoalieRating06.Add("UkkoPekka Luukkonen","Goal");
PlayerGStatsGoalieRating06.Add("Malcolm Subban","Goal");
PlayerGStatsGoalieRating06.Add("Dustin Tokarski","Goal");
PlayerGStatsGoalieRating06.Add("Jacob Markstrom","Penalty");
PlayerGStatsGoalieRating06.Add("Daniel Vladar","Goal");
PlayerGStatsGoalieRating06.Add("Adam Werner","Save, to RD");
PlayerGStatsGoalieRating06.Add("Frederik Andersen","Save, to Any");
PlayerGStatsGoalieRating06.Add("Pyotr Kochetkov","Save, to LD");
PlayerGStatsGoalieRating06.Add("Jack LaFontaine","Save, to RD");
PlayerGStatsGoalieRating06.Add("Alex Lyon","Goal");
PlayerGStatsGoalieRating06.Add("Antti Raanta","Penalty");
PlayerGStatsGoalieRating06.Add("JeanFrancois Berube","Goal");
PlayerGStatsGoalieRating06.Add("Joonas Korpisalo","Save, to LD");
PlayerGStatsGoalieRating06.Add("Elvis Merzlikins","Save, to RD");
PlayerGStatsGoalieRating06.Add("Daniil Tarasov","Penalty");
PlayerGStatsGoalieRating06.Add("Collin Delia","Save, to RD");
PlayerGStatsGoalieRating06.Add("Kevin Lankinen","Save, to Any");
PlayerGStatsGoalieRating06.Add("Petr Mrazek","Save, to Any");
PlayerGStatsGoalieRating06.Add("Arvid Soderblom","Rebound");
PlayerGStatsGoalieRating06.Add("Alex Stalock","Save, to RD");
PlayerGStatsGoalieRating06.Add("Justus Annunen","Save, to RD");
PlayerGStatsGoalieRating06.Add("Pavel Francouz","Save, to LD");
PlayerGStatsGoalieRating06.Add("Alexandar Georgiev","Save, to C");
PlayerGStatsGoalieRating06.Add("Hunter Miska","Goal");
PlayerGStatsGoalieRating06.Add("Landon Bow","Save, to Any");
PlayerGStatsGoalieRating06.Add("Braden Holtby","Save, to LD");
PlayerGStatsGoalieRating06.Add("Anton Khudobin","Save, to RD");
PlayerGStatsGoalieRating06.Add("Jake Oettinger","Save, to RW");
PlayerGStatsGoalieRating06.Add("Scott Wedgewood","Goal");
PlayerGStatsGoalieRating06.Add("Kaden Fulcher","Save, to LW");
PlayerGStatsGoalieRating06.Add("Magnus Hellberg","Save, to RW");
PlayerGStatsGoalieRating06.Add("Ville Husso","Goal");
PlayerGStatsGoalieRating06.Add("Alex Nedeljkovic","Save, to C");
PlayerGStatsGoalieRating06.Add("Jack Campbell","Save, to Any");
PlayerGStatsGoalieRating06.Add("Mikko Koskinen","Penalty");
PlayerGStatsGoalieRating06.Add("Calvin Pickard","Rebound");
PlayerGStatsGoalieRating06.Add("Stuart Skinner","Save, to LD");
PlayerGStatsGoalieRating06.Add("Mike Smith","Save, to LW");
PlayerGStatsGoalieRating06.Add("Sergei Bobrovsky","Save, to RD");
PlayerGStatsGoalieRating06.Add("Christopher Gibson","Goal");
PlayerGStatsGoalieRating06.Add("Jonas Johansson","Goal");
PlayerGStatsGoalieRating06.Add("Spencer Knight","Save, to RD");
PlayerGStatsGoalieRating06.Add("Pheonix Copley","Goal");
PlayerGStatsGoalieRating06.Add("Cal Petersen","Save, to Any");
PlayerGStatsGoalieRating06.Add("Jonathan Quick","Penalty");
PlayerGStatsGoalieRating06.Add("Garret Sparks","Save, to LD");
PlayerGStatsGoalieRating06.Add("MarcAndre Fleury","Save, to Any");
PlayerGStatsGoalieRating06.Add("Filip Gustavsson","Save, to RD");
PlayerGStatsGoalieRating06.Add("Jake Allen","Penalty");
PlayerGStatsGoalieRating06.Add("Andrew Hammond","Save, to RD");
PlayerGStatsGoalieRating06.Add("Michael McNiven","Save, to LD");
PlayerGStatsGoalieRating06.Add("Samuel Montembeault","Goal");
PlayerGStatsGoalieRating06.Add("Carey Price","Save, to LD");
PlayerGStatsGoalieRating06.Add("Cayden Primeau","Save, to LD");
PlayerGStatsGoalieRating06.Add("Connor Ingram","Rebound");
PlayerGStatsGoalieRating06.Add("Juuse Saros","Save, to RD");
PlayerGStatsGoalieRating06.Add("Jonathan Bernier","Save, to RD");
PlayerGStatsGoalieRating06.Add("Mackenzie Blackwood","Penalty");
PlayerGStatsGoalieRating06.Add("Nico Daws","Penalty");
PlayerGStatsGoalieRating06.Add("Akira Schmid","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating06.Add("Gilles Senn","Save, to C");
PlayerGStatsGoalieRating06.Add("Vitek Vanecek","Save, to LW");
PlayerGStatsGoalieRating06.Add("Cory Schneider","Save, to RD");
PlayerGStatsGoalieRating06.Add("Ilya Sorokin","Save, to LW");
PlayerGStatsGoalieRating06.Add("Semyon Varlamov","Penalty");
PlayerGStatsGoalieRating06.Add("Louis Domingue","Goal");
PlayerGStatsGoalieRating06.Add("Jaroslav Halak","Save, to RW");
PlayerGStatsGoalieRating06.Add("Adam Huska","Rebound");
PlayerGStatsGoalieRating06.Add("Keith Kinkaid","Save, to Any");
PlayerGStatsGoalieRating06.Add("Igor Shesterkin","Save, to LW");
PlayerGStatsGoalieRating06.Add("Anton Forsberg","Goal");
PlayerGStatsGoalieRating06.Add("Mads Sogaard","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating06.Add("Cam Talbot","Save, to Any");
PlayerGStatsGoalieRating06.Add("Carter Hart","Save, to RW");
PlayerGStatsGoalieRating06.Add("Felix Sandstrom","Rebound");
PlayerGStatsGoalieRating06.Add("Casey DeSmith","Penalty");
PlayerGStatsGoalieRating06.Add("Tristan Jarry","Save, to C");
PlayerGStatsGoalieRating06.Add("Antoine Bibeau","Rebound");
PlayerGStatsGoalieRating06.Add("Joey Daccord","Save, to RD");
PlayerGStatsGoalieRating06.Add("Chris Driedger","Save, to LW");
PlayerGStatsGoalieRating06.Add("Philipp Grubauer","Save, to LW");
PlayerGStatsGoalieRating06.Add("Martin Jones","Goal");
PlayerGStatsGoalieRating06.Add("Aaron Dell","Goal");
PlayerGStatsGoalieRating06.Add("Adin Hill","Save, to LW");
PlayerGStatsGoalieRating06.Add("Kaapo Kahkonen","Goal");
PlayerGStatsGoalieRating06.Add("James Reimer","Save, to C");
PlayerGStatsGoalieRating06.Add("Zachary Sawchenko","Save, to LD");
PlayerGStatsGoalieRating06.Add("Jordan Binnington","Penalty");
PlayerGStatsGoalieRating06.Add("Jon Gillies","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating06.Add("Thomas Greiss","Penalty");
PlayerGStatsGoalieRating06.Add("Joel Hofer","Save, to Any");
PlayerGStatsGoalieRating06.Add("Hugo Alnefelt","Save, to Any");
PlayerGStatsGoalieRating06.Add("Brian Elliott","Save, to RD");
PlayerGStatsGoalieRating06.Add("Maxime Lagace","Rebound");
PlayerGStatsGoalieRating06.Add("Alexei Melnichuk","Rebound");
PlayerGStatsGoalieRating06.Add("Andrei Vasilevskiy","Save, to RD");
PlayerGStatsGoalieRating06.Add("Michael Hutchinson","Goal");
PlayerGStatsGoalieRating06.Add("Carter Hutton","Goal");
PlayerGStatsGoalieRating06.Add("Erik Kallgren","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating06.Add("Matt Murray","Save, to RW");
PlayerGStatsGoalieRating06.Add("Ilya Samsonov","Penalty");
PlayerGStatsGoalieRating06.Add("Joseph Woll","Rebound");
PlayerGStatsGoalieRating06.Add("Thatcher Demko","Save, to LD");
PlayerGStatsGoalieRating06.Add("Michael DiPietro","Penalty");
PlayerGStatsGoalieRating06.Add("Spencer Martin","Save, to LD");
PlayerGStatsGoalieRating06.Add("Laurent Brossoit","Save, to LW");
PlayerGStatsGoalieRating06.Add("Robin Lehner","Save, to LW");
PlayerGStatsGoalieRating06.Add("Logan Thompson","Save, to RW");
PlayerGStatsGoalieRating06.Add("Zachary Fucale","Save, to RW");
PlayerGStatsGoalieRating06.Add("Darcy Kuemper","Save, to RD");
PlayerGStatsGoalieRating06.Add("Charlie Lindgren","Penalty");
PlayerGStatsGoalieRating06.Add("Connor Hellebuyck","Penalty");
PlayerGStatsGoalieRating06.Add("David Rittich","Save, to RW");

FrPlayerGStatsGoalieRating06.Add("John GibsonANA","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("JeanSebastian GiguereANA","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Guy HebertANA","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Jonas HillerANA","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Johan HedbergATL","Goal");
FrPlayerGStatsGoalieRating06.Add("Kari LehtonenATL","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Pasi NurminenATL","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Ondrej PavelecATL","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Gerry CheeversBOS","Goal");
FrPlayerGStatsGoalieRating06.Add("Reggie LemelinBOS","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Andy MoogBOS","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Tuukka RaskBOS","Penalty");
FrPlayerGStatsGoalieRating06.Add("Dominik HasekBUF","Penalty");
FrPlayerGStatsGoalieRating06.Add("Clint MalarchukBUF","OUT: Rebound / IRB: Goal");
FrPlayerGStatsGoalieRating06.Add("Ryan MillerBUF","Penalty");
FrPlayerGStatsGoalieRating06.Add("Daren PuppaBUF","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Trevor KiddCAL","Goal");
FrPlayerGStatsGoalieRating06.Add("Miikka KiprusoffCAL","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Roman TurekCAL","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Mike VernonCAL","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Arturs IrbeCAR","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Petr MrazekCAR","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Cam WardCAR","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Kevin WeekesCAR","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Sergei BobrovskyCBJ","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Marc DenisCBJ","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Pascal LeclaireCBJ","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Steve MasonCBJ","Penalty");
FrPlayerGStatsGoalieRating06.Add("Ed BelfourCHI","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Corey CrawfordCHI","Penalty");
FrPlayerGStatsGoalieRating06.Add("Tony EspositoCHI","Penalty");
FrPlayerGStatsGoalieRating06.Add("Glenn HallCHI","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("David AebischerCOL","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Peter BudajCOL","Goal");
FrPlayerGStatsGoalieRating06.Add("Patrick RoyCOL","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Semyon VarlamovCOL","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Ed BelfourDAL","Penalty");
FrPlayerGStatsGoalieRating06.Add("Kari LehtonenDAL","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Andy MoogDAL","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Marty TurcoDAL","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Tim CheveldaeDET","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Jimmy HowardDET","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Chris OsgoodDET","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Terry SawchukDET","Penalty");
FrPlayerGStatsGoalieRating06.Add("Grant FuhrEDM","Rebound");
FrPlayerGStatsGoalieRating06.Add("Andy MoogEDM","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Bill RanfordEDM","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Tommy SaloEDM","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Sean BurkeFLA","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Roberto LuongoFLA","Penalty");
FrPlayerGStatsGoalieRating06.Add("John VanbiesbrouckFLA","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Tomas VokounFLA","Penalty");
FrPlayerGStatsGoalieRating06.Add("Sean BurkeHAR","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Mike LiutHAR","Penalty");
FrPlayerGStatsGoalieRating06.Add("Greg MillenHAR","Rebound");
FrPlayerGStatsGoalieRating06.Add("Peter SidorkiewiczHAR","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Stephane FisetLAK","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Kelly HrudeyLAK","Rebound");
FrPlayerGStatsGoalieRating06.Add("Jonathan QuickLAK","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Rogatien VachonLAK","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating06.Add("Don BeaupreMNS","Rebound");
FrPlayerGStatsGoalieRating06.Add("Jon CaseyMNS","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Cesare ManiagoMNS","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Gilles MelocheMNS","Rebound");
FrPlayerGStatsGoalieRating06.Add("Niklas BackstromMNW","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Devan DubnykMNW","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Manny FernandezMNW","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Dwayne RolosonMNW","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Ken DrydenMON","Penalty");
FrPlayerGStatsGoalieRating06.Add("Jacques PlanteMON","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Carey PriceMON","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Patrick RoyMON","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Mike DunhamNAS","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Chris MasonNAS","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Pekka RinneNAS","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Tomas VokounNAS","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Martin BrodeurNJD","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Chico ReschNJD","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Cory SchneiderNJD","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Chris TerreriNJD","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Rick DiPietroNYI","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Kelly HrudeyNYI","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Chico ReschNYI","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Billy SmithNYI","Goal");
FrPlayerGStatsGoalieRating06.Add("Eddie GiacominNYR","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Henrik LundqvistNYR","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Mike RichterNYR","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Gump WorsleyNYR","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Craig AndersonOTT","Penalty");
FrPlayerGStatsGoalieRating06.Add("Patrick LalimeOTT","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Damian RhodesOTT","Goal");
FrPlayerGStatsGoalieRating06.Add("Ron TugnuttOTT","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Brian BoucherPHI","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Ron HextallPHI","Goal");
FrPlayerGStatsGoalieRating06.Add("Pelle LindberghPHI","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Bernie ParentPHI","Rebound");
FrPlayerGStatsGoalieRating06.Add("Ilya BryzgalovPHO","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Sean BurkePHO","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Nikolai KhabibulinPHO","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Mike SmithPHO","Save, to LW");
FrPlayerGStatsGoalieRating06.Add("Tom BarrassoPIT","Goal");
FrPlayerGStatsGoalieRating06.Add("MarcAndre FleuryPIT","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Denis HerronPIT","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Ken WreggetPIT","Goal");
FrPlayerGStatsGoalieRating06.Add("Dan BouchardQUE","Rebound");
FrPlayerGStatsGoalieRating06.Add("Stephane FisetQUE","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Mario GosselinQUE","Penalty");
FrPlayerGStatsGoalieRating06.Add("Ron TugnuttQUE","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating06.Add("Arturs IrbeSJS","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Martin JonesSJS","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Evgeni NabokovSJS","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Antti NiemiSJS","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Jake AllenSTL","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Grant FuhrSTL","Goal");
FrPlayerGStatsGoalieRating06.Add("Curtis JosephSTL","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Mike LiutSTL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating06.Add("Ben BishopTBL","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Nikolai KhabibulinTBL","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Daren PuppaTBL","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Andrei VasilevskiyTBL","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Johnny BowerTOR","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Turk BrodaTOR","Goal");
FrPlayerGStatsGoalieRating06.Add("Curtis JosephTOR","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Felix PotvinTOR","Save, to C");
FrPlayerGStatsGoalieRating06.Add("Richard BrodeurVAN","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Dan CloutierVAN","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Roberto LuongoVAN","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Kirk McLeanVAN","Save, to RD");
FrPlayerGStatsGoalieRating06.Add("Don BeaupreWAS","Save, to LD");
FrPlayerGStatsGoalieRating06.Add("Braden HoltbyWAS","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Al JensenWAS","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Olaf KolzigWAS","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Bob EssensaWPG","Goal");
FrPlayerGStatsGoalieRating06.Add("Brian HaywardWPG","Save, to Any");
FrPlayerGStatsGoalieRating06.Add("Connor HellebuyckWPG","Save, to RW");
FrPlayerGStatsGoalieRating06.Add("Ondrej PavelecWPG","Save, to LD");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}