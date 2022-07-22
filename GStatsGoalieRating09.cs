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

public class GStatsGoalieRating09 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating09 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating09 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating09.Add("Lukas Dostal","Goal");
PlayerGStatsGoalieRating09.Add("John Gibson","Penalty");
PlayerGStatsGoalieRating09.Add("Thomas Hodges","Save, to Any");
PlayerGStatsGoalieRating09.Add("Anthony Stolarz","Goal");
PlayerGStatsGoalieRating09.Add("Josef Korenar","Goal");
PlayerGStatsGoalieRating09.Add("Ivan Prosvetov","Rebound");
PlayerGStatsGoalieRating09.Add("Harri Sateri","Goal");
PlayerGStatsGoalieRating09.Add("Karel Vejmelka","Save, to C");
PlayerGStatsGoalieRating09.Add("Troy Grosenick","Save, to RD");
PlayerGStatsGoalieRating09.Add("Jeremy Swayman","Save, to RD");
PlayerGStatsGoalieRating09.Add("Linus Ullmark","Save, to LW");
PlayerGStatsGoalieRating09.Add("Craig Anderson","Goal");
PlayerGStatsGoalieRating09.Add("Eric Comrie","Goal");
PlayerGStatsGoalieRating09.Add("Michael Houser","Goal");
PlayerGStatsGoalieRating09.Add("UkkoPekka Luukkonen","Save, to Any");
PlayerGStatsGoalieRating09.Add("Malcolm Subban","OUT: Goal / IRB: Penalty");
PlayerGStatsGoalieRating09.Add("Dustin Tokarski","Goal");
PlayerGStatsGoalieRating09.Add("Jacob Markstrom","Save, to RD");
PlayerGStatsGoalieRating09.Add("Daniel Vladar","Goal");
PlayerGStatsGoalieRating09.Add("Adam Werner","Save, to C");
PlayerGStatsGoalieRating09.Add("Frederik Andersen","Save, to C");
PlayerGStatsGoalieRating09.Add("Pyotr Kochetkov","Save, to LD");
PlayerGStatsGoalieRating09.Add("Jack LaFontaine","Save, to LW");
PlayerGStatsGoalieRating09.Add("Alex Lyon","Goal");
PlayerGStatsGoalieRating09.Add("Antti Raanta","Save, to LD");
PlayerGStatsGoalieRating09.Add("JeanFrancois Berube","Goal");
PlayerGStatsGoalieRating09.Add("Joonas Korpisalo","Goal");
PlayerGStatsGoalieRating09.Add("Elvis Merzlikins","Save, to Any");
PlayerGStatsGoalieRating09.Add("Daniil Tarasov","Save, to LD");
PlayerGStatsGoalieRating09.Add("Collin Delia","Goal");
PlayerGStatsGoalieRating09.Add("Kevin Lankinen","Goal");
PlayerGStatsGoalieRating09.Add("Petr Mrazek","Save, to RW");
PlayerGStatsGoalieRating09.Add("Arvid Soderblom","Rebound");
PlayerGStatsGoalieRating09.Add("Alex Stalock","Penalty");
PlayerGStatsGoalieRating09.Add("Justus Annunen","OUT: Penalty / IRB: Breakaway");
PlayerGStatsGoalieRating09.Add("Pavel Francouz","Goal");
PlayerGStatsGoalieRating09.Add("Alexandar Georgiev","Save, to C");
PlayerGStatsGoalieRating09.Add("Hunter Miska","Goal");
PlayerGStatsGoalieRating09.Add("Landon Bow","Save, to RD");
PlayerGStatsGoalieRating09.Add("Braden Holtby","Goal");
PlayerGStatsGoalieRating09.Add("Anton Khudobin","Penalty");
PlayerGStatsGoalieRating09.Add("Jake Oettinger","Save, to RD");
PlayerGStatsGoalieRating09.Add("Scott Wedgewood","Goal");
PlayerGStatsGoalieRating09.Add("Kaden Fulcher","Save, to Any");
PlayerGStatsGoalieRating09.Add("Magnus Hellberg","Goal");
PlayerGStatsGoalieRating09.Add("Ville Husso","Save, to LD");
PlayerGStatsGoalieRating09.Add("Alex Nedeljkovic","OUT: Breakaway / IRB: Penalty");
PlayerGStatsGoalieRating09.Add("Jack Campbell","Save, to LW");
PlayerGStatsGoalieRating09.Add("Mikko Koskinen","Save, to LD");
PlayerGStatsGoalieRating09.Add("Calvin Pickard","Rebound");
PlayerGStatsGoalieRating09.Add("Stuart Skinner","Save, to Any");
PlayerGStatsGoalieRating09.Add("Mike Smith","Goal");
PlayerGStatsGoalieRating09.Add("Sergei Bobrovsky","Save, to C");
PlayerGStatsGoalieRating09.Add("Christopher Gibson","Save, to LW");
PlayerGStatsGoalieRating09.Add("Jonas Johansson","Save, to RW");
PlayerGStatsGoalieRating09.Add("Spencer Knight","Save, to RD");
PlayerGStatsGoalieRating09.Add("Pheonix Copley","Goal");
PlayerGStatsGoalieRating09.Add("Cal Petersen","Save, to Any");
PlayerGStatsGoalieRating09.Add("Jonathan Quick","Goal");
PlayerGStatsGoalieRating09.Add("Garret Sparks","Save, to RW");
PlayerGStatsGoalieRating09.Add("MarcAndre Fleury","Save, to RW");
PlayerGStatsGoalieRating09.Add("Filip Gustavsson","Goal");
PlayerGStatsGoalieRating09.Add("Jake Allen","Save, to RD");
PlayerGStatsGoalieRating09.Add("Andrew Hammond","Rebound");
PlayerGStatsGoalieRating09.Add("Michael McNiven","Save, to Any");
PlayerGStatsGoalieRating09.Add("Samuel Montembeault","Goal");
PlayerGStatsGoalieRating09.Add("Carey Price","Save, to LW");
PlayerGStatsGoalieRating09.Add("Cayden Primeau","Save, to C");
PlayerGStatsGoalieRating09.Add("Connor Ingram","Save, to LW");
PlayerGStatsGoalieRating09.Add("Juuse Saros","Save, to LD");
PlayerGStatsGoalieRating09.Add("Jonathan Bernier","Goal");
PlayerGStatsGoalieRating09.Add("Mackenzie Blackwood","Save, to RW");
PlayerGStatsGoalieRating09.Add("Nico Daws","Save, to RW");
PlayerGStatsGoalieRating09.Add("Akira Schmid","Goal");
PlayerGStatsGoalieRating09.Add("Gilles Senn","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating09.Add("Vitek Vanecek","Save, to C");
PlayerGStatsGoalieRating09.Add("Cory Schneider","Goal");
PlayerGStatsGoalieRating09.Add("Ilya Sorokin","Save, to LW");
PlayerGStatsGoalieRating09.Add("Semyon Varlamov","Save, to C");
PlayerGStatsGoalieRating09.Add("Louis Domingue","Save, to C");
PlayerGStatsGoalieRating09.Add("Jaroslav Halak","Save, to Any");
PlayerGStatsGoalieRating09.Add("Adam Huska","Save, to C");
PlayerGStatsGoalieRating09.Add("Keith Kinkaid","Save, to LW");
PlayerGStatsGoalieRating09.Add("Igor Shesterkin","Save, to RD");
PlayerGStatsGoalieRating09.Add("Anton Forsberg","Save, to Any");
PlayerGStatsGoalieRating09.Add("Mads Sogaard","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating09.Add("Cam Talbot","Save, to C");
PlayerGStatsGoalieRating09.Add("Carter Hart","Save, to LW");
PlayerGStatsGoalieRating09.Add("Felix Sandstrom","Save, to Any");
PlayerGStatsGoalieRating09.Add("Casey DeSmith","Save, to C");
PlayerGStatsGoalieRating09.Add("Tristan Jarry","Save, to LD");
PlayerGStatsGoalieRating09.Add("Antoine Bibeau","Save, to Any");
PlayerGStatsGoalieRating09.Add("Joey Daccord","Save, to LW");
PlayerGStatsGoalieRating09.Add("Chris Driedger","Breakaway");
PlayerGStatsGoalieRating09.Add("Philipp Grubauer","Save, to RD");
PlayerGStatsGoalieRating09.Add("Martin Jones","Save, to Any");
PlayerGStatsGoalieRating09.Add("Aaron Dell","Save, to LD");
PlayerGStatsGoalieRating09.Add("Adin Hill","Save, to C");
PlayerGStatsGoalieRating09.Add("Kaapo Kahkonen","Goal");
PlayerGStatsGoalieRating09.Add("James Reimer","Goal");
PlayerGStatsGoalieRating09.Add("Zachary Sawchenko","Save, to Any");
PlayerGStatsGoalieRating09.Add("Jordan Binnington","Save, to C");
PlayerGStatsGoalieRating09.Add("Jon Gillies","Goal");
PlayerGStatsGoalieRating09.Add("Thomas Greiss","Save, to C");
PlayerGStatsGoalieRating09.Add("Joel Hofer","Save, to RD");
PlayerGStatsGoalieRating09.Add("Hugo Alnefelt","Save, to C");
PlayerGStatsGoalieRating09.Add("Brian Elliott","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating09.Add("Maxime Lagace","Rebound");
PlayerGStatsGoalieRating09.Add("Alexei Melnichuk","Save, to LD");
PlayerGStatsGoalieRating09.Add("Andrei Vasilevskiy","OUT: Penalty / IRB: Breakaway");
PlayerGStatsGoalieRating09.Add("Michael Hutchinson","Goal");
PlayerGStatsGoalieRating09.Add("Carter Hutton","Goal");
PlayerGStatsGoalieRating09.Add("Erik Kallgren","Goal");
PlayerGStatsGoalieRating09.Add("Matt Murray","Goal");
PlayerGStatsGoalieRating09.Add("Ilya Samsonov","Save, to Any");
PlayerGStatsGoalieRating09.Add("Joseph Woll","Save, to Any");
PlayerGStatsGoalieRating09.Add("Thatcher Demko","Save, to Any");
PlayerGStatsGoalieRating09.Add("Michael DiPietro","Save, to Any");
PlayerGStatsGoalieRating09.Add("Spencer Martin","Save, to Any");
PlayerGStatsGoalieRating09.Add("Laurent Brossoit","Save, to Any");
PlayerGStatsGoalieRating09.Add("Robin Lehner","Save, to RD");
PlayerGStatsGoalieRating09.Add("Logan Thompson","Save, to Any");
PlayerGStatsGoalieRating09.Add("Zachary Fucale","Goal");
PlayerGStatsGoalieRating09.Add("Darcy Kuemper","Save, to RW");
PlayerGStatsGoalieRating09.Add("Charlie Lindgren","Save, to Any");
PlayerGStatsGoalieRating09.Add("Connor Hellebuyck","Save, to LW");
PlayerGStatsGoalieRating09.Add("David Rittich","OUT: Goal / IRB: Penalty");

FrPlayerGStatsGoalieRating09.Add("John GibsonANA","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("JeanSebastian GiguereANA","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Guy HebertANA","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Jonas HillerANA","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Johan HedbergATL","Goal");
FrPlayerGStatsGoalieRating09.Add("Kari LehtonenATL","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Pasi NurminenATL","Goal");
FrPlayerGStatsGoalieRating09.Add("Ondrej PavelecATL","Penalty");
FrPlayerGStatsGoalieRating09.Add("Gerry CheeversBOS","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating09.Add("Reggie LemelinBOS","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Andy MoogBOS","Save, to C");
FrPlayerGStatsGoalieRating09.Add("Tuukka RaskBOS","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Dominik HasekBUF","Penalty");
FrPlayerGStatsGoalieRating09.Add("Clint MalarchukBUF","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating09.Add("Ryan MillerBUF","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Daren PuppaBUF","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating09.Add("Trevor KiddCAL","Goal");
FrPlayerGStatsGoalieRating09.Add("Miikka KiprusoffCAL","Save, to C");
FrPlayerGStatsGoalieRating09.Add("Roman TurekCAL","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating09.Add("Mike VernonCAL","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Arturs IrbeCAR","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating09.Add("Petr MrazekCAR","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Cam WardCAR","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Kevin WeekesCAR","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Sergei BobrovskyCBJ","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Marc DenisCBJ","Goal");
FrPlayerGStatsGoalieRating09.Add("Pascal LeclaireCBJ","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Steve MasonCBJ","Goal");
FrPlayerGStatsGoalieRating09.Add("Ed BelfourCHI","Goal");
FrPlayerGStatsGoalieRating09.Add("Corey CrawfordCHI","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Tony EspositoCHI","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating09.Add("Glenn HallCHI","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("David AebischerCOL","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Peter BudajCOL","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating09.Add("Patrick RoyCOL","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Semyon VarlamovCOL","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Ed BelfourDAL","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Kari LehtonenDAL","Save, to C");
FrPlayerGStatsGoalieRating09.Add("Andy MoogDAL","Goal");
FrPlayerGStatsGoalieRating09.Add("Marty TurcoDAL","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Tim CheveldaeDET","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Jimmy HowardDET","Save, to C");
FrPlayerGStatsGoalieRating09.Add("Chris OsgoodDET","Goal");
FrPlayerGStatsGoalieRating09.Add("Terry SawchukDET","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating09.Add("Grant FuhrEDM","Rebound");
FrPlayerGStatsGoalieRating09.Add("Andy MoogEDM","Rebound");
FrPlayerGStatsGoalieRating09.Add("Bill RanfordEDM","Rebound");
FrPlayerGStatsGoalieRating09.Add("Tommy SaloEDM","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating09.Add("Sean BurkeFLA","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Roberto LuongoFLA","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("John VanbiesbrouckFLA","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Tomas VokounFLA","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Sean BurkeHAR","Goal");
FrPlayerGStatsGoalieRating09.Add("Mike LiutHAR","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Greg MillenHAR","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Peter SidorkiewiczHAR","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Stephane FisetLAK","Goal");
FrPlayerGStatsGoalieRating09.Add("Kelly HrudeyLAK","Rebound");
FrPlayerGStatsGoalieRating09.Add("Jonathan QuickLAK","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Rogatien VachonLAK","Goal");
FrPlayerGStatsGoalieRating09.Add("Don BeaupreMNS","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Jon CaseyMNS","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Cesare ManiagoMNS","Goal");
FrPlayerGStatsGoalieRating09.Add("Gilles MelocheMNS","Rebound");
FrPlayerGStatsGoalieRating09.Add("Niklas BackstromMNW","Penalty");
FrPlayerGStatsGoalieRating09.Add("Devan DubnykMNW","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Manny FernandezMNW","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Dwayne RolosonMNW","Save, to C");
FrPlayerGStatsGoalieRating09.Add("Ken DrydenMON","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Jacques PlanteMON","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Carey PriceMON","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Patrick RoyMON","Goal");
FrPlayerGStatsGoalieRating09.Add("Mike DunhamNAS","Penalty");
FrPlayerGStatsGoalieRating09.Add("Chris MasonNAS","Penalty");
FrPlayerGStatsGoalieRating09.Add("Pekka RinneNAS","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Tomas VokounNAS","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Martin BrodeurNJD","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Chico ReschNJD","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Cory SchneiderNJD","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Chris TerreriNJD","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Rick DiPietroNYI","Goal");
FrPlayerGStatsGoalieRating09.Add("Kelly HrudeyNYI","Rebound");
FrPlayerGStatsGoalieRating09.Add("Chico ReschNYI","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Billy SmithNYI","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Eddie GiacominNYR","Goal");
FrPlayerGStatsGoalieRating09.Add("Henrik LundqvistNYR","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Mike RichterNYR","Goal");
FrPlayerGStatsGoalieRating09.Add("Gump WorsleyNYR","Penalty");
FrPlayerGStatsGoalieRating09.Add("Craig AndersonOTT","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Patrick LalimeOTT","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Damian RhodesOTT","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating09.Add("Ron TugnuttOTT","Goal");
FrPlayerGStatsGoalieRating09.Add("Brian BoucherPHI","Goal");
FrPlayerGStatsGoalieRating09.Add("Ron HextallPHI","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Pelle LindberghPHI","OUT: Penalty / IRB: Breakaway");
FrPlayerGStatsGoalieRating09.Add("Bernie ParentPHI","Rebound");
FrPlayerGStatsGoalieRating09.Add("Ilya BryzgalovPHO","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Sean BurkePHO","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Nikolai KhabibulinPHO","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Mike SmithPHO","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Tom BarrassoPIT","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("MarcAndre FleuryPIT","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Denis HerronPIT","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Ken WreggetPIT","Goal");
FrPlayerGStatsGoalieRating09.Add("Dan BouchardQUE","Rebound");
FrPlayerGStatsGoalieRating09.Add("Stephane FisetQUE","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Mario GosselinQUE","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating09.Add("Ron TugnuttQUE","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Arturs IrbeSJS","Rebound");
FrPlayerGStatsGoalieRating09.Add("Martin JonesSJS","Goal");
FrPlayerGStatsGoalieRating09.Add("Evgeni NabokovSJS","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Antti NiemiSJS","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Jake AllenSTL","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Grant FuhrSTL","Goal");
FrPlayerGStatsGoalieRating09.Add("Curtis JosephSTL","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Mike LiutSTL","Rebound");
FrPlayerGStatsGoalieRating09.Add("Ben BishopTBL","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Nikolai KhabibulinTBL","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Daren PuppaTBL","Goal");
FrPlayerGStatsGoalieRating09.Add("Andrei VasilevskiyTBL","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Johnny BowerTOR","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Turk BrodaTOR","Goal");
FrPlayerGStatsGoalieRating09.Add("Curtis JosephTOR","Breakaway");
FrPlayerGStatsGoalieRating09.Add("Felix PotvinTOR","Save, to C");
FrPlayerGStatsGoalieRating09.Add("Richard BrodeurVAN","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Dan CloutierVAN","Goal");
FrPlayerGStatsGoalieRating09.Add("Roberto LuongoVAN","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Kirk McLeanVAN","Save, to RW");
FrPlayerGStatsGoalieRating09.Add("Don BeaupreWAS","Save, to RD");
FrPlayerGStatsGoalieRating09.Add("Braden HoltbyWAS","Save, to LW");
FrPlayerGStatsGoalieRating09.Add("Al JensenWAS","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Olaf KolzigWAS","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating09.Add("Bob EssensaWPG","Save, to Any");
FrPlayerGStatsGoalieRating09.Add("Brian HaywardWPG","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Connor HellebuyckWPG","Save, to LD");
FrPlayerGStatsGoalieRating09.Add("Ondrej PavelecWPG","Goal");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}