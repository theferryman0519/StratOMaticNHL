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

public class GStatsGoalieRating02 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating02 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating02 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating02.Add("Lukas Dostal","Save, to Any");
PlayerGStatsGoalieRating02.Add("John Gibson","Save, to RD");
PlayerGStatsGoalieRating02.Add("Thomas Hodges","Breakaway");
PlayerGStatsGoalieRating02.Add("Anthony Stolarz","Save, to LW");
PlayerGStatsGoalieRating02.Add("Josef Korenar","Save, to C");
PlayerGStatsGoalieRating02.Add("Ivan Prosvetov","Goal");
PlayerGStatsGoalieRating02.Add("Harri Sateri","Penalty");
PlayerGStatsGoalieRating02.Add("Karel Vejmelka","Save, to Any");
PlayerGStatsGoalieRating02.Add("Troy Grosenick","Save, to RD");
PlayerGStatsGoalieRating02.Add("Jeremy Swayman","Rebound");
PlayerGStatsGoalieRating02.Add("Linus Ullmark","Rebound");
PlayerGStatsGoalieRating02.Add("Craig Anderson","Save, to LD");
PlayerGStatsGoalieRating02.Add("Eric Comrie","Save, to LD");
PlayerGStatsGoalieRating02.Add("Michael Houser","Save, to Any");
PlayerGStatsGoalieRating02.Add("UkkoPekka Luukkonen","Save, to C");
PlayerGStatsGoalieRating02.Add("Malcolm Subban","Save, to Any");
PlayerGStatsGoalieRating02.Add("Dustin Tokarski","Save, to LD");
PlayerGStatsGoalieRating02.Add("Jacob Markstrom","Rebound");
PlayerGStatsGoalieRating02.Add("Daniel Vladar","Rebound");
PlayerGStatsGoalieRating02.Add("Adam Werner","Rebound");
PlayerGStatsGoalieRating02.Add("Frederik Andersen","Rebound");
PlayerGStatsGoalieRating02.Add("Pyotr Kochetkov","Rebound");
PlayerGStatsGoalieRating02.Add("Jack LaFontaine","Goal");
PlayerGStatsGoalieRating02.Add("Alex Lyon","Save, to C");
PlayerGStatsGoalieRating02.Add("Antti Raanta","Rebound");
PlayerGStatsGoalieRating02.Add("JeanFrancois Berube","Save, to RD");
PlayerGStatsGoalieRating02.Add("Joonas Korpisalo","Save, to C");
PlayerGStatsGoalieRating02.Add("Elvis Merzlikins","Rebound");
PlayerGStatsGoalieRating02.Add("Daniil Tarasov","Rebound");
PlayerGStatsGoalieRating02.Add("Collin Delia","Save, to RD");
PlayerGStatsGoalieRating02.Add("Kevin Lankinen","Save, to Any");
PlayerGStatsGoalieRating02.Add("Petr Mrazek","Rebound");
PlayerGStatsGoalieRating02.Add("Arvid Soderblom","Goal");
PlayerGStatsGoalieRating02.Add("Alex Stalock","Rebound");
PlayerGStatsGoalieRating02.Add("Justus Annunen","Save, to LD");
PlayerGStatsGoalieRating02.Add("Pavel Francouz","Rebound");
PlayerGStatsGoalieRating02.Add("Alexandar Georgiev","Rebound");
PlayerGStatsGoalieRating02.Add("Hunter Miska","Save, to RW");
PlayerGStatsGoalieRating02.Add("Landon Bow","Save, to LW");
PlayerGStatsGoalieRating02.Add("Braden Holtby","Save, to Any");
PlayerGStatsGoalieRating02.Add("Anton Khudobin","Rebound");
PlayerGStatsGoalieRating02.Add("Jake Oettinger","Save, to LW");
PlayerGStatsGoalieRating02.Add("Scott Wedgewood","Save, to RD");
PlayerGStatsGoalieRating02.Add("Kaden Fulcher","Goal");
PlayerGStatsGoalieRating02.Add("Magnus Hellberg","Rebound");
PlayerGStatsGoalieRating02.Add("Ville Husso","Save, to C");
PlayerGStatsGoalieRating02.Add("Alex Nedeljkovic","Save, to RD");
PlayerGStatsGoalieRating02.Add("Jack Campbell","Rebound");
PlayerGStatsGoalieRating02.Add("Mikko Koskinen","Rebound");
PlayerGStatsGoalieRating02.Add("Calvin Pickard","Save, to Any");
PlayerGStatsGoalieRating02.Add("Stuart Skinner","Save, to RD");
PlayerGStatsGoalieRating02.Add("Mike Smith","Rebound");
PlayerGStatsGoalieRating02.Add("Sergei Bobrovsky","Rebound");
PlayerGStatsGoalieRating02.Add("Christopher Gibson","Save, to RW");
PlayerGStatsGoalieRating02.Add("Jonas Johansson","Save, to RW");
PlayerGStatsGoalieRating02.Add("Spencer Knight","Save, to C");
PlayerGStatsGoalieRating02.Add("Pheonix Copley","Save, to RW");
PlayerGStatsGoalieRating02.Add("Cal Petersen","Save, to Any");
PlayerGStatsGoalieRating02.Add("Jonathan Quick","Rebound");
PlayerGStatsGoalieRating02.Add("Garret Sparks","Goal");
PlayerGStatsGoalieRating02.Add("MarcAndre Fleury","Rebound");
PlayerGStatsGoalieRating02.Add("Filip Gustavsson","Save, to Any");
PlayerGStatsGoalieRating02.Add("Jake Allen","Rebound");
PlayerGStatsGoalieRating02.Add("Andrew Hammond","Goal");
PlayerGStatsGoalieRating02.Add("Michael McNiven","Goal");
PlayerGStatsGoalieRating02.Add("Samuel Montembeault","Save, to C");
PlayerGStatsGoalieRating02.Add("Carey Price","Rebound");
PlayerGStatsGoalieRating02.Add("Cayden Primeau","Save, to C");
PlayerGStatsGoalieRating02.Add("Connor Ingram","Goal");
PlayerGStatsGoalieRating02.Add("Juuse Saros","Rebound");
PlayerGStatsGoalieRating02.Add("Jonathan Bernier","Save, to RW");
PlayerGStatsGoalieRating02.Add("Mackenzie Blackwood","Save, to RD");
PlayerGStatsGoalieRating02.Add("Nico Daws","Rebound");
PlayerGStatsGoalieRating02.Add("Akira Schmid","Save, to RD");
PlayerGStatsGoalieRating02.Add("Gilles Senn","Save, to Any");
PlayerGStatsGoalieRating02.Add("Vitek Vanecek","Rebound");
PlayerGStatsGoalieRating02.Add("Cory Schneider","Save, to LW");
PlayerGStatsGoalieRating02.Add("Ilya Sorokin","Save, to Any");
PlayerGStatsGoalieRating02.Add("Semyon Varlamov","Rebound");
PlayerGStatsGoalieRating02.Add("Louis Domingue","Save, to RD");
PlayerGStatsGoalieRating02.Add("Jaroslav Halak","Rebound");
PlayerGStatsGoalieRating02.Add("Adam Huska","Save, to RD");
PlayerGStatsGoalieRating02.Add("Keith Kinkaid","Save, to Any");
PlayerGStatsGoalieRating02.Add("Igor Shesterkin","Save, to RD");
PlayerGStatsGoalieRating02.Add("Anton Forsberg","Save, to C");
PlayerGStatsGoalieRating02.Add("Mads Sogaard","Save, to LW");
PlayerGStatsGoalieRating02.Add("Cam Talbot","Save, to LD");
PlayerGStatsGoalieRating02.Add("Carter Hart","Rebound");
PlayerGStatsGoalieRating02.Add("Felix Sandstrom","Goal");
PlayerGStatsGoalieRating02.Add("Casey DeSmith","Rebound");
PlayerGStatsGoalieRating02.Add("Tristan Jarry","Rebound");
PlayerGStatsGoalieRating02.Add("Antoine Bibeau","Goal");
PlayerGStatsGoalieRating02.Add("Joey Daccord","Rebound");
PlayerGStatsGoalieRating02.Add("Chris Driedger","Save, to RD");
PlayerGStatsGoalieRating02.Add("Philipp Grubauer","Rebound");
PlayerGStatsGoalieRating02.Add("Martin Jones","Save, to RD");
PlayerGStatsGoalieRating02.Add("Aaron Dell","Save, to C");
PlayerGStatsGoalieRating02.Add("Adin Hill","Rebound");
PlayerGStatsGoalieRating02.Add("Kaapo Kahkonen","Save, to Any");
PlayerGStatsGoalieRating02.Add("James Reimer","Save, to Any");
PlayerGStatsGoalieRating02.Add("Zachary Sawchenko","Save, to RD");
PlayerGStatsGoalieRating02.Add("Jordan Binnington","Rebound");
PlayerGStatsGoalieRating02.Add("Jon Gillies","Save, to LD");
PlayerGStatsGoalieRating02.Add("Thomas Greiss","Rebound");
PlayerGStatsGoalieRating02.Add("Joel Hofer","Goal");
PlayerGStatsGoalieRating02.Add("Hugo Alnefelt","Rebound");
PlayerGStatsGoalieRating02.Add("Brian Elliott","Save, to RD");
PlayerGStatsGoalieRating02.Add("Maxime Lagace","Save, to LD");
PlayerGStatsGoalieRating02.Add("Alexei Melnichuk","Save, to RW");
PlayerGStatsGoalieRating02.Add("Andrei Vasilevskiy","Rebound");
PlayerGStatsGoalieRating02.Add("Michael Hutchinson","Save, to LW");
PlayerGStatsGoalieRating02.Add("Carter Hutton","Save, to RD");
PlayerGStatsGoalieRating02.Add("Erik Kallgren","Save, to RW");
PlayerGStatsGoalieRating02.Add("Matt Murray","Save, to RW");
PlayerGStatsGoalieRating02.Add("Ilya Samsonov","Save, to RW");
PlayerGStatsGoalieRating02.Add("Joseph Woll","Save, to LD");
PlayerGStatsGoalieRating02.Add("Thatcher Demko","Rebound");
PlayerGStatsGoalieRating02.Add("Michael DiPietro","Rebound");
PlayerGStatsGoalieRating02.Add("Spencer Martin","Save, to RD");
PlayerGStatsGoalieRating02.Add("Laurent Brossoit","Save, to Any");
PlayerGStatsGoalieRating02.Add("Robin Lehner","Rebound");
PlayerGStatsGoalieRating02.Add("Logan Thompson","Rebound");
PlayerGStatsGoalieRating02.Add("Zachary Fucale","Save, to LD");
PlayerGStatsGoalieRating02.Add("Darcy Kuemper","Rebound");
PlayerGStatsGoalieRating02.Add("Charlie Lindgren","Save, to LD");
PlayerGStatsGoalieRating02.Add("Connor Hellebuyck","Rebound");
PlayerGStatsGoalieRating02.Add("David Rittich","Save, to LD");

FrPlayerGStatsGoalieRating02.Add("John GibsonANA","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("JeanSebastian GiguereANA","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Guy HebertANA","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Jonas HillerANA","Rebound");
FrPlayerGStatsGoalieRating02.Add("Johan HedbergATL","Penalty");
FrPlayerGStatsGoalieRating02.Add("Kari LehtonenATL","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Pasi NurminenATL","Penalty");
FrPlayerGStatsGoalieRating02.Add("Ondrej PavelecATL","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Gerry CheeversBOS","Penalty");
FrPlayerGStatsGoalieRating02.Add("Reggie LemelinBOS","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Andy MoogBOS","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating02.Add("Tuukka RaskBOS","Rebound");
FrPlayerGStatsGoalieRating02.Add("Dominik HasekBUF","Rebound");
FrPlayerGStatsGoalieRating02.Add("Clint MalarchukBUF","Penalty");
FrPlayerGStatsGoalieRating02.Add("Ryan MillerBUF","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Daren PuppaBUF","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Trevor KiddCAL","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Miikka KiprusoffCAL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Roman TurekCAL","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Mike VernonCAL","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Arturs IrbeCAR","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Petr MrazekCAR","Rebound");
FrPlayerGStatsGoalieRating02.Add("Cam WardCAR","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Kevin WeekesCAR","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Sergei BobrovskyCBJ","Rebound");
FrPlayerGStatsGoalieRating02.Add("Marc DenisCBJ","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Pascal LeclaireCBJ","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Steve MasonCBJ","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Ed BelfourCHI","Penalty");
FrPlayerGStatsGoalieRating02.Add("Corey CrawfordCHI","Rebound");
FrPlayerGStatsGoalieRating02.Add("Tony EspositoCHI","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Glenn HallCHI","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("David AebischerCOL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Peter BudajCOL","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Patrick RoyCOL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating02.Add("Semyon VarlamovCOL","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Ed BelfourDAL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Kari LehtonenDAL","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Andy MoogDAL","Penalty");
FrPlayerGStatsGoalieRating02.Add("Marty TurcoDAL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating02.Add("Tim CheveldaeDET","Goal");
FrPlayerGStatsGoalieRating02.Add("Jimmy HowardDET","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Chris OsgoodDET","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Terry SawchukDET","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Grant FuhrEDM","Goal");
FrPlayerGStatsGoalieRating02.Add("Andy MoogEDM","Goal");
FrPlayerGStatsGoalieRating02.Add("Bill RanfordEDM","Goal");
FrPlayerGStatsGoalieRating02.Add("Tommy SaloEDM","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Sean BurkeFLA","Penalty");
FrPlayerGStatsGoalieRating02.Add("Roberto LuongoFLA","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("John VanbiesbrouckFLA","Penalty");
FrPlayerGStatsGoalieRating02.Add("Tomas VokounFLA","Save, to LD");
FrPlayerGStatsGoalieRating02.Add("Sean BurkeHAR","Penalty");
FrPlayerGStatsGoalieRating02.Add("Mike LiutHAR","Goal");
FrPlayerGStatsGoalieRating02.Add("Greg MillenHAR","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Peter SidorkiewiczHAR","Goal");
FrPlayerGStatsGoalieRating02.Add("Stephane FisetLAK","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Kelly HrudeyLAK","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating02.Add("Jonathan QuickLAK","Rebound");
FrPlayerGStatsGoalieRating02.Add("Rogatien VachonLAK","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Don BeaupreMNS","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Jon CaseyMNS","Penalty");
FrPlayerGStatsGoalieRating02.Add("Cesare ManiagoMNS","Save, to LD");
FrPlayerGStatsGoalieRating02.Add("Gilles MelocheMNS","Goal");
FrPlayerGStatsGoalieRating02.Add("Niklas BackstromMNW","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Devan DubnykMNW","Rebound");
FrPlayerGStatsGoalieRating02.Add("Manny FernandezMNW","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Dwayne RolosonMNW","Rebound");
FrPlayerGStatsGoalieRating02.Add("Ken DrydenMON","Rebound");
FrPlayerGStatsGoalieRating02.Add("Jacques PlanteMON","Rebound");
FrPlayerGStatsGoalieRating02.Add("Carey PriceMON","Rebound");
FrPlayerGStatsGoalieRating02.Add("Patrick RoyMON","Penalty");
FrPlayerGStatsGoalieRating02.Add("Mike DunhamNAS","Save, to LD");
FrPlayerGStatsGoalieRating02.Add("Chris MasonNAS","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Pekka RinneNAS","Rebound");
FrPlayerGStatsGoalieRating02.Add("Tomas VokounNAS","Penalty");
FrPlayerGStatsGoalieRating02.Add("Martin BrodeurNJD","Rebound");
FrPlayerGStatsGoalieRating02.Add("Chico ReschNJD","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Cory SchneiderNJD","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Chris TerreriNJD","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Rick DiPietroNYI","Penalty");
FrPlayerGStatsGoalieRating02.Add("Kelly HrudeyNYI","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Chico ReschNYI","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Billy SmithNYI","Penalty");
FrPlayerGStatsGoalieRating02.Add("Eddie GiacominNYR","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Henrik LundqvistNYR","Rebound");
FrPlayerGStatsGoalieRating02.Add("Mike RichterNYR","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Gump WorsleyNYR","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Craig AndersonOTT","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Patrick LalimeOTT","Rebound");
FrPlayerGStatsGoalieRating02.Add("Damian RhodesOTT","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Ron TugnuttOTT","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Brian BoucherPHI","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Ron HextallPHI","Penalty");
FrPlayerGStatsGoalieRating02.Add("Pelle LindberghPHI","Goal");
FrPlayerGStatsGoalieRating02.Add("Bernie ParentPHI","Penalty");
FrPlayerGStatsGoalieRating02.Add("Ilya BryzgalovPHO","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Sean BurkePHO","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating02.Add("Nikolai KhabibulinPHO","Save, to Any");
FrPlayerGStatsGoalieRating02.Add("Mike SmithPHO","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Tom BarrassoPIT","OUT: Penalty / IRB: Breakaway");
FrPlayerGStatsGoalieRating02.Add("MarcAndre FleuryPIT","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Denis HerronPIT","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating02.Add("Ken WreggetPIT","Penalty");
FrPlayerGStatsGoalieRating02.Add("Dan BouchardQUE","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Stephane FisetQUE","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Mario GosselinQUE","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Ron TugnuttQUE","Goal");
FrPlayerGStatsGoalieRating02.Add("Arturs IrbeSJS","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Martin JonesSJS","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Evgeni NabokovSJS","Rebound");
FrPlayerGStatsGoalieRating02.Add("Antti NiemiSJS","Rebound");
FrPlayerGStatsGoalieRating02.Add("Jake AllenSTL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Grant FuhrSTL","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Curtis JosephSTL","Save, to LW");
FrPlayerGStatsGoalieRating02.Add("Mike LiutSTL","Goal");
FrPlayerGStatsGoalieRating02.Add("Ben BishopTBL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Nikolai KhabibulinTBL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Daren PuppaTBL","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Andrei VasilevskiyTBL","Rebound");
FrPlayerGStatsGoalieRating02.Add("Johnny BowerTOR","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Turk BrodaTOR","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Curtis JosephTOR","Rebound");
FrPlayerGStatsGoalieRating02.Add("Felix PotvinTOR","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Richard BrodeurVAN","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Dan CloutierVAN","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating02.Add("Roberto LuongoVAN","Rebound");
FrPlayerGStatsGoalieRating02.Add("Kirk McLeanVAN","Goal");
FrPlayerGStatsGoalieRating02.Add("Don BeaupreWAS","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Braden HoltbyWAS","Rebound");
FrPlayerGStatsGoalieRating02.Add("Al JensenWAS","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating02.Add("Olaf KolzigWAS","Save, to C");
FrPlayerGStatsGoalieRating02.Add("Bob EssensaWPG","Save, to RD");
FrPlayerGStatsGoalieRating02.Add("Brian HaywardWPG","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Connor HellebuyckWPG","Save, to RW");
FrPlayerGStatsGoalieRating02.Add("Ondrej PavelecWPG","Save, to RW");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}