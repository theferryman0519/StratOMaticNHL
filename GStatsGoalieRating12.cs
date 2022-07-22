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

public class GStatsGoalieRating12 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating12 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating12 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating12.Add("Lukas Dostal","Save, to RW");
PlayerGStatsGoalieRating12.Add("John Gibson","Rebound");
PlayerGStatsGoalieRating12.Add("Thomas Hodges","Save, to LD");
PlayerGStatsGoalieRating12.Add("Anthony Stolarz","Save, to LD");
PlayerGStatsGoalieRating12.Add("Josef Korenar","Save, to LD");
PlayerGStatsGoalieRating12.Add("Ivan Prosvetov","Save, to Any");
PlayerGStatsGoalieRating12.Add("Harri Sateri","Rebound");
PlayerGStatsGoalieRating12.Add("Karel Vejmelka","Save, to Any");
PlayerGStatsGoalieRating12.Add("Troy Grosenick","Rebound");
PlayerGStatsGoalieRating12.Add("Jeremy Swayman","Save, to Any");
PlayerGStatsGoalieRating12.Add("Linus Ullmark","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Craig Anderson","Save, to LD");
PlayerGStatsGoalieRating12.Add("Eric Comrie","Save, to Any");
PlayerGStatsGoalieRating12.Add("Michael Houser","Save, to Any");
PlayerGStatsGoalieRating12.Add("UkkoPekka Luukkonen","Rebound");
PlayerGStatsGoalieRating12.Add("Malcolm Subban","Save, to RD");
PlayerGStatsGoalieRating12.Add("Dustin Tokarski","Save, to LD");
PlayerGStatsGoalieRating12.Add("Jacob Markstrom","Rebound");
PlayerGStatsGoalieRating12.Add("Daniel Vladar","Rebound");
PlayerGStatsGoalieRating12.Add("Adam Werner","Save, to RW");
PlayerGStatsGoalieRating12.Add("Frederik Andersen","Rebound");
PlayerGStatsGoalieRating12.Add("Pyotr Kochetkov","Rebound");
PlayerGStatsGoalieRating12.Add("Jack LaFontaine","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Alex Lyon","Save, to C");
PlayerGStatsGoalieRating12.Add("Antti Raanta","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("JeanFrancois Berube","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Joonas Korpisalo","Rebound");
PlayerGStatsGoalieRating12.Add("Elvis Merzlikins","Rebound");
PlayerGStatsGoalieRating12.Add("Daniil Tarasov","Rebound");
PlayerGStatsGoalieRating12.Add("Collin Delia","Save, to RW");
PlayerGStatsGoalieRating12.Add("Kevin Lankinen","Save, to Any");
PlayerGStatsGoalieRating12.Add("Petr Mrazek","Breakaway");
PlayerGStatsGoalieRating12.Add("Arvid Soderblom","Save, to C");
PlayerGStatsGoalieRating12.Add("Alex Stalock","Rebound");
PlayerGStatsGoalieRating12.Add("Justus Annunen","Save, to Any");
PlayerGStatsGoalieRating12.Add("Pavel Francouz","Rebound");
PlayerGStatsGoalieRating12.Add("Alexandar Georgiev","Save, to LD");
PlayerGStatsGoalieRating12.Add("Hunter Miska","Save, to LW");
PlayerGStatsGoalieRating12.Add("Landon Bow","Save, to LW");
PlayerGStatsGoalieRating12.Add("Braden Holtby","Save, to LW");
PlayerGStatsGoalieRating12.Add("Anton Khudobin","Save, to RW");
PlayerGStatsGoalieRating12.Add("Jake Oettinger","Rebound");
PlayerGStatsGoalieRating12.Add("Scott Wedgewood","Save, to C");
PlayerGStatsGoalieRating12.Add("Kaden Fulcher","Goal");
PlayerGStatsGoalieRating12.Add("Magnus Hellberg","Rebound");
PlayerGStatsGoalieRating12.Add("Ville Husso","Save, to Any");
PlayerGStatsGoalieRating12.Add("Alex Nedeljkovic","Save, to RD");
PlayerGStatsGoalieRating12.Add("Jack Campbell","Save, to C");
PlayerGStatsGoalieRating12.Add("Mikko Koskinen","Rebound");
PlayerGStatsGoalieRating12.Add("Calvin Pickard","Save, to LW");
PlayerGStatsGoalieRating12.Add("Stuart Skinner","Rebound");
PlayerGStatsGoalieRating12.Add("Mike Smith","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Sergei Bobrovsky","Rebound");
PlayerGStatsGoalieRating12.Add("Christopher Gibson","Save, to RD");
PlayerGStatsGoalieRating12.Add("Jonas Johansson","Save, to LW");
PlayerGStatsGoalieRating12.Add("Spencer Knight","Save, to LW");
PlayerGStatsGoalieRating12.Add("Pheonix Copley","Breakaway");
PlayerGStatsGoalieRating12.Add("Cal Petersen","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Jonathan Quick","Rebound");
PlayerGStatsGoalieRating12.Add("Garret Sparks","Save, to LW");
PlayerGStatsGoalieRating12.Add("MarcAndre Fleury","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("Filip Gustavsson","Rebound");
PlayerGStatsGoalieRating12.Add("Jake Allen","Rebound");
PlayerGStatsGoalieRating12.Add("Andrew Hammond","Goal");
PlayerGStatsGoalieRating12.Add("Michael McNiven","Goal");
PlayerGStatsGoalieRating12.Add("Samuel Montembeault","Save, to RW");
PlayerGStatsGoalieRating12.Add("Carey Price","Rebound");
PlayerGStatsGoalieRating12.Add("Cayden Primeau","Save, to RD");
PlayerGStatsGoalieRating12.Add("Connor Ingram","Goal");
PlayerGStatsGoalieRating12.Add("Juuse Saros","Rebound");
PlayerGStatsGoalieRating12.Add("Jonathan Bernier","Save, to C");
PlayerGStatsGoalieRating12.Add("Mackenzie Blackwood","Rebound");
PlayerGStatsGoalieRating12.Add("Nico Daws","Save, to LD");
PlayerGStatsGoalieRating12.Add("Akira Schmid","Save, to C");
PlayerGStatsGoalieRating12.Add("Gilles Senn","Save, to C");
PlayerGStatsGoalieRating12.Add("Vitek Vanecek","Rebound");
PlayerGStatsGoalieRating12.Add("Cory Schneider","Rebound");
PlayerGStatsGoalieRating12.Add("Ilya Sorokin","Save, to Any");
PlayerGStatsGoalieRating12.Add("Semyon Varlamov","Rebound");
PlayerGStatsGoalieRating12.Add("Louis Domingue","Save, to LW");
PlayerGStatsGoalieRating12.Add("Jaroslav Halak","Save, to RW");
PlayerGStatsGoalieRating12.Add("Adam Huska","Save, to RD");
PlayerGStatsGoalieRating12.Add("Keith Kinkaid","Save, to RD");
PlayerGStatsGoalieRating12.Add("Igor Shesterkin","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("Anton Forsberg","Save, to Any");
PlayerGStatsGoalieRating12.Add("Mads Sogaard","Save, to LW");
PlayerGStatsGoalieRating12.Add("Cam Talbot","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("Carter Hart","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Felix Sandstrom","Goal");
PlayerGStatsGoalieRating12.Add("Casey DeSmith","Breakaway");
PlayerGStatsGoalieRating12.Add("Tristan Jarry","Rebound");
PlayerGStatsGoalieRating12.Add("Antoine Bibeau","Goal");
PlayerGStatsGoalieRating12.Add("Joey Daccord","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("Chris Driedger","Save, to RD");
PlayerGStatsGoalieRating12.Add("Philipp Grubauer","Breakaway");
PlayerGStatsGoalieRating12.Add("Martin Jones","Rebound");
PlayerGStatsGoalieRating12.Add("Aaron Dell","Save, to LD");
PlayerGStatsGoalieRating12.Add("Adin Hill","Rebound");
PlayerGStatsGoalieRating12.Add("Kaapo Kahkonen","Save, to RD");
PlayerGStatsGoalieRating12.Add("James Reimer","Rebound");
PlayerGStatsGoalieRating12.Add("Zachary Sawchenko","Save, to LW");
PlayerGStatsGoalieRating12.Add("Jordan Binnington","Breakaway");
PlayerGStatsGoalieRating12.Add("Jon Gillies","Save, to LD");
PlayerGStatsGoalieRating12.Add("Thomas Greiss","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("Joel Hofer","Save, to LW");
PlayerGStatsGoalieRating12.Add("Hugo Alnefelt","Rebound");
PlayerGStatsGoalieRating12.Add("Brian Elliott","Rebound");
PlayerGStatsGoalieRating12.Add("Maxime Lagace","Save, to RW");
PlayerGStatsGoalieRating12.Add("Alexei Melnichuk","Save, to Any");
PlayerGStatsGoalieRating12.Add("Andrei Vasilevskiy","Save, to Any");
PlayerGStatsGoalieRating12.Add("Michael Hutchinson","Rebound");
PlayerGStatsGoalieRating12.Add("Carter Hutton","Save, to LD");
PlayerGStatsGoalieRating12.Add("Erik Kallgren","Save, to RD");
PlayerGStatsGoalieRating12.Add("Matt Murray","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating12.Add("Ilya Samsonov","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating12.Add("Joseph Woll","Goal");
PlayerGStatsGoalieRating12.Add("Thatcher Demko","Rebound");
PlayerGStatsGoalieRating12.Add("Michael DiPietro","Rebound");
PlayerGStatsGoalieRating12.Add("Spencer Martin","Rebound");
PlayerGStatsGoalieRating12.Add("Laurent Brossoit","Rebound");
PlayerGStatsGoalieRating12.Add("Robin Lehner","Save, to RD");
PlayerGStatsGoalieRating12.Add("Logan Thompson","Save, to Any");
PlayerGStatsGoalieRating12.Add("Zachary Fucale","Rebound");
PlayerGStatsGoalieRating12.Add("Darcy Kuemper","Breakaway");
PlayerGStatsGoalieRating12.Add("Charlie Lindgren","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating12.Add("Connor Hellebuyck","Rebound");
PlayerGStatsGoalieRating12.Add("David Rittich","OUT: Rebound / IRB: Breakaway");

FrPlayerGStatsGoalieRating12.Add("John GibsonANA","Rebound");
FrPlayerGStatsGoalieRating12.Add("JeanSebastian GiguereANA","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Guy HebertANA","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Jonas HillerANA","Rebound");
FrPlayerGStatsGoalieRating12.Add("Johan HedbergATL","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Kari LehtonenATL","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Pasi NurminenATL","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Ondrej PavelecATL","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Gerry CheeversBOS","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Reggie LemelinBOS","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Andy MoogBOS","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Tuukka RaskBOS","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Dominik HasekBUF","Rebound");
FrPlayerGStatsGoalieRating12.Add("Clint MalarchukBUF","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Ryan MillerBUF","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating12.Add("Daren PuppaBUF","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Trevor KiddCAL","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Miikka KiprusoffCAL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Roman TurekCAL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Mike VernonCAL","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Arturs IrbeCAR","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating12.Add("Petr MrazekCAR","Rebound");
FrPlayerGStatsGoalieRating12.Add("Cam WardCAR","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Kevin WeekesCAR","Rebound");
FrPlayerGStatsGoalieRating12.Add("Sergei BobrovskyCBJ","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Marc DenisCBJ","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Pascal LeclaireCBJ","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Steve MasonCBJ","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Ed BelfourCHI","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Corey CrawfordCHI","Rebound");
FrPlayerGStatsGoalieRating12.Add("Tony EspositoCHI","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Glenn HallCHI","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("David AebischerCOL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Peter BudajCOL","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Patrick RoyCOL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Semyon VarlamovCOL","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Ed BelfourDAL","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Kari LehtonenDAL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Andy MoogDAL","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Marty TurcoDAL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Tim CheveldaeDET","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Jimmy HowardDET","Rebound");
FrPlayerGStatsGoalieRating12.Add("Chris OsgoodDET","Rebound");
FrPlayerGStatsGoalieRating12.Add("Terry SawchukDET","Rebound");
FrPlayerGStatsGoalieRating12.Add("Grant FuhrEDM","Penalty");
FrPlayerGStatsGoalieRating12.Add("Andy MoogEDM","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Bill RanfordEDM","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Tommy SaloEDM","Rebound");
FrPlayerGStatsGoalieRating12.Add("Sean BurkeFLA","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Roberto LuongoFLA","Rebound");
FrPlayerGStatsGoalieRating12.Add("John VanbiesbrouckFLA","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Tomas VokounFLA","Rebound");
FrPlayerGStatsGoalieRating12.Add("Sean BurkeHAR","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Mike LiutHAR","Goal");
FrPlayerGStatsGoalieRating12.Add("Greg MillenHAR","Goal");
FrPlayerGStatsGoalieRating12.Add("Peter SidorkiewiczHAR","Goal");
FrPlayerGStatsGoalieRating12.Add("Stephane FisetLAK","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Kelly HrudeyLAK","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Jonathan QuickLAK","Rebound");
FrPlayerGStatsGoalieRating12.Add("Rogatien VachonLAK","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Don BeaupreMNS","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Jon CaseyMNS","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Cesare ManiagoMNS","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Gilles MelocheMNS","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Niklas BackstromMNW","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Devan DubnykMNW","Rebound");
FrPlayerGStatsGoalieRating12.Add("Manny FernandezMNW","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Dwayne RolosonMNW","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Ken DrydenMON","Rebound");
FrPlayerGStatsGoalieRating12.Add("Jacques PlanteMON","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating12.Add("Carey PriceMON","Rebound");
FrPlayerGStatsGoalieRating12.Add("Patrick RoyMON","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Mike DunhamNAS","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Chris MasonNAS","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Pekka RinneNAS","Rebound");
FrPlayerGStatsGoalieRating12.Add("Tomas VokounNAS","Rebound");
FrPlayerGStatsGoalieRating12.Add("Martin BrodeurNJD","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Chico ReschNJD","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Cory SchneiderNJD","Rebound");
FrPlayerGStatsGoalieRating12.Add("Chris TerreriNJD","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Rick DiPietroNYI","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Kelly HrudeyNYI","Goal");
FrPlayerGStatsGoalieRating12.Add("Chico ReschNYI","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Billy SmithNYI","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Eddie GiacominNYR","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Henrik LundqvistNYR","Rebound");
FrPlayerGStatsGoalieRating12.Add("Mike RichterNYR","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Gump WorsleyNYR","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Craig AndersonOTT","Save, to LD");
FrPlayerGStatsGoalieRating12.Add("Patrick LalimeOTT","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Damian RhodesOTT","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Ron TugnuttOTT","Rebound");
FrPlayerGStatsGoalieRating12.Add("Brian BoucherPHI","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Ron HextallPHI","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Pelle LindberghPHI","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Bernie ParentPHI","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Ilya BryzgalovPHO","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating12.Add("Sean BurkePHO","Rebound");
FrPlayerGStatsGoalieRating12.Add("Nikolai KhabibulinPHO","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating12.Add("Mike SmithPHO","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Tom BarrassoPIT","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("MarcAndre FleuryPIT","Rebound");
FrPlayerGStatsGoalieRating12.Add("Denis HerronPIT","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Ken WreggetPIT","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Dan BouchardQUE","Goal");
FrPlayerGStatsGoalieRating12.Add("Stephane FisetQUE","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Mario GosselinQUE","Goal");
FrPlayerGStatsGoalieRating12.Add("Ron TugnuttQUE","Goal");
FrPlayerGStatsGoalieRating12.Add("Arturs IrbeSJS","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Martin JonesSJS","Rebound");
FrPlayerGStatsGoalieRating12.Add("Evgeni NabokovSJS","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Antti NiemiSJS","Rebound");
FrPlayerGStatsGoalieRating12.Add("Jake AllenSTL","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating12.Add("Grant FuhrSTL","Penalty");
FrPlayerGStatsGoalieRating12.Add("Curtis JosephSTL","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Mike LiutSTL","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Ben BishopTBL","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Nikolai KhabibulinTBL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating12.Add("Daren PuppaTBL","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Andrei VasilevskiyTBL","Rebound");
FrPlayerGStatsGoalieRating12.Add("Johnny BowerTOR","Rebound");
FrPlayerGStatsGoalieRating12.Add("Turk BrodaTOR","Save, to LW");
FrPlayerGStatsGoalieRating12.Add("Curtis JosephTOR","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating12.Add("Felix PotvinTOR","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Richard BrodeurVAN","Goal");
FrPlayerGStatsGoalieRating12.Add("Dan CloutierVAN","Rebound");
FrPlayerGStatsGoalieRating12.Add("Roberto LuongoVAN","Rebound");
FrPlayerGStatsGoalieRating12.Add("Kirk McLeanVAN","Save, to C");
FrPlayerGStatsGoalieRating12.Add("Don BeaupreWAS","Breakaway");
FrPlayerGStatsGoalieRating12.Add("Braden HoltbyWAS","Rebound");
FrPlayerGStatsGoalieRating12.Add("Al JensenWAS","Save, to Any");
FrPlayerGStatsGoalieRating12.Add("Olaf KolzigWAS","Save, to RD");
FrPlayerGStatsGoalieRating12.Add("Bob EssensaWPG","Save, to RW");
FrPlayerGStatsGoalieRating12.Add("Brian HaywardWPG","Penalty");
FrPlayerGStatsGoalieRating12.Add("Connor HellebuyckWPG","Rebound");
FrPlayerGStatsGoalieRating12.Add("Ondrej PavelecWPG","Save, to LD");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}