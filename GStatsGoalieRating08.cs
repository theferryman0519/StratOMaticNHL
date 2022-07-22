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

public class GStatsGoalieRating08 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating08 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating08 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating08.Add("Lukas Dostal","Save, to C");
PlayerGStatsGoalieRating08.Add("John Gibson","Save, to RW");
PlayerGStatsGoalieRating08.Add("Thomas Hodges","Save, to C");
PlayerGStatsGoalieRating08.Add("Anthony Stolarz","Save, to Any");
PlayerGStatsGoalieRating08.Add("Josef Korenar","Save, to C");
PlayerGStatsGoalieRating08.Add("Ivan Prosvetov","Save, to RD");
PlayerGStatsGoalieRating08.Add("Harri Sateri","Save, to RD");
PlayerGStatsGoalieRating08.Add("Karel Vejmelka","Goal");
PlayerGStatsGoalieRating08.Add("Troy Grosenick","Save, to LD");
PlayerGStatsGoalieRating08.Add("Jeremy Swayman","Save, to RW");
PlayerGStatsGoalieRating08.Add("Linus Ullmark","Save, to LW");
PlayerGStatsGoalieRating08.Add("Craig Anderson","Save, to LD");
PlayerGStatsGoalieRating08.Add("Eric Comrie","Save, to LW");
PlayerGStatsGoalieRating08.Add("Michael Houser","Save, to Any");
PlayerGStatsGoalieRating08.Add("UkkoPekka Luukkonen","Goal");
PlayerGStatsGoalieRating08.Add("Malcolm Subban","Save, to RW");
PlayerGStatsGoalieRating08.Add("Dustin Tokarski","Save, to LD");
PlayerGStatsGoalieRating08.Add("Jacob Markstrom","Breakaway");
PlayerGStatsGoalieRating08.Add("Daniel Vladar","Save, to LW");
PlayerGStatsGoalieRating08.Add("Adam Werner","Save, to C");
PlayerGStatsGoalieRating08.Add("Frederik Andersen","Breakaway");
PlayerGStatsGoalieRating08.Add("Pyotr Kochetkov","Save, to Any");
PlayerGStatsGoalieRating08.Add("Jack LaFontaine","Save, to LW");
PlayerGStatsGoalieRating08.Add("Alex Lyon","Save, to RW");
PlayerGStatsGoalieRating08.Add("Antti Raanta","Save, to RW");
PlayerGStatsGoalieRating08.Add("JeanFrancois Berube","Save, to Any");
PlayerGStatsGoalieRating08.Add("Joonas Korpisalo","Save, to LD");
PlayerGStatsGoalieRating08.Add("Elvis Merzlikins","Save, to Any");
PlayerGStatsGoalieRating08.Add("Daniil Tarasov","Save, to LD");
PlayerGStatsGoalieRating08.Add("Collin Delia","Save, to Any");
PlayerGStatsGoalieRating08.Add("Kevin Lankinen","Save, to LW");
PlayerGStatsGoalieRating08.Add("Petr Mrazek","Save, to Any");
PlayerGStatsGoalieRating08.Add("Arvid Soderblom","Breakaway");
PlayerGStatsGoalieRating08.Add("Alex Stalock","Breakaway");
PlayerGStatsGoalieRating08.Add("Justus Annunen","Goal");
PlayerGStatsGoalieRating08.Add("Pavel Francouz","Save, to RW");
PlayerGStatsGoalieRating08.Add("Alexandar Georgiev","Save, to LD");
PlayerGStatsGoalieRating08.Add("Hunter Miska","Goal");
PlayerGStatsGoalieRating08.Add("Landon Bow","Goal");
PlayerGStatsGoalieRating08.Add("Braden Holtby","Save, to LD");
PlayerGStatsGoalieRating08.Add("Anton Khudobin","Save, to RW");
PlayerGStatsGoalieRating08.Add("Jake Oettinger","Save, to RW");
PlayerGStatsGoalieRating08.Add("Scott Wedgewood","Save, to RD");
PlayerGStatsGoalieRating08.Add("Kaden Fulcher","Rebound");
PlayerGStatsGoalieRating08.Add("Magnus Hellberg","Save, to LD");
PlayerGStatsGoalieRating08.Add("Ville Husso","Goal");
PlayerGStatsGoalieRating08.Add("Alex Nedeljkovic","Rebound");
PlayerGStatsGoalieRating08.Add("Jack Campbell","Save, to Any");
PlayerGStatsGoalieRating08.Add("Mikko Koskinen","Save, to LW");
PlayerGStatsGoalieRating08.Add("Calvin Pickard","Save, to C");
PlayerGStatsGoalieRating08.Add("Stuart Skinner","Save, to LD");
PlayerGStatsGoalieRating08.Add("Mike Smith","Penalty");
PlayerGStatsGoalieRating08.Add("Sergei Bobrovsky","Save, to LW");
PlayerGStatsGoalieRating08.Add("Christopher Gibson","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating08.Add("Jonas Johansson","Goal");
PlayerGStatsGoalieRating08.Add("Spencer Knight","Save, to LW");
PlayerGStatsGoalieRating08.Add("Pheonix Copley","Save, to C");
PlayerGStatsGoalieRating08.Add("Cal Petersen","Save, to LD");
PlayerGStatsGoalieRating08.Add("Jonathan Quick","Save, to LW");
PlayerGStatsGoalieRating08.Add("Garret Sparks","Save, to C");
PlayerGStatsGoalieRating08.Add("MarcAndre Fleury","Save, to Any");
PlayerGStatsGoalieRating08.Add("Filip Gustavsson","Save, to RD");
PlayerGStatsGoalieRating08.Add("Jake Allen","Save, to LW");
PlayerGStatsGoalieRating08.Add("Andrew Hammond","Save, to RD");
PlayerGStatsGoalieRating08.Add("Michael McNiven","Rebound");
PlayerGStatsGoalieRating08.Add("Samuel Montembeault","Breakaway");
PlayerGStatsGoalieRating08.Add("Carey Price","Save, to LW");
PlayerGStatsGoalieRating08.Add("Cayden Primeau","Goal");
PlayerGStatsGoalieRating08.Add("Connor Ingram","Save, to LD");
PlayerGStatsGoalieRating08.Add("Juuse Saros","Save, to C");
PlayerGStatsGoalieRating08.Add("Jonathan Bernier","Save, to RD");
PlayerGStatsGoalieRating08.Add("Mackenzie Blackwood","Save, to RD");
PlayerGStatsGoalieRating08.Add("Nico Daws","Save, to C");
PlayerGStatsGoalieRating08.Add("Akira Schmid","Goal");
PlayerGStatsGoalieRating08.Add("Gilles Senn","Save, to C");
PlayerGStatsGoalieRating08.Add("Vitek Vanecek","Save, to Any");
PlayerGStatsGoalieRating08.Add("Cory Schneider","Save, to C");
PlayerGStatsGoalieRating08.Add("Ilya Sorokin","Save, to RD");
PlayerGStatsGoalieRating08.Add("Semyon Varlamov","Save, to C");
PlayerGStatsGoalieRating08.Add("Louis Domingue","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating08.Add("Jaroslav Halak","Breakaway");
PlayerGStatsGoalieRating08.Add("Adam Huska","Goal");
PlayerGStatsGoalieRating08.Add("Keith Kinkaid","Goal");
PlayerGStatsGoalieRating08.Add("Igor Shesterkin","Save, to C");
PlayerGStatsGoalieRating08.Add("Anton Forsberg","Goal");
PlayerGStatsGoalieRating08.Add("Mads Sogaard","Save, to RW");
PlayerGStatsGoalieRating08.Add("Cam Talbot","Save, to LD");
PlayerGStatsGoalieRating08.Add("Carter Hart","Save, to C");
PlayerGStatsGoalieRating08.Add("Felix Sandstrom","Save, to LD");
PlayerGStatsGoalieRating08.Add("Casey DeSmith","Save, to LD");
PlayerGStatsGoalieRating08.Add("Tristan Jarry","Save, to LW");
PlayerGStatsGoalieRating08.Add("Antoine Bibeau","Save, to Any");
PlayerGStatsGoalieRating08.Add("Joey Daccord","Save, to RD");
PlayerGStatsGoalieRating08.Add("Chris Driedger","Save, to LW");
PlayerGStatsGoalieRating08.Add("Philipp Grubauer","Save, to RD");
PlayerGStatsGoalieRating08.Add("Martin Jones","Goal");
PlayerGStatsGoalieRating08.Add("Aaron Dell","Goal");
PlayerGStatsGoalieRating08.Add("Adin Hill","Save, to LD");
PlayerGStatsGoalieRating08.Add("Kaapo Kahkonen","Save, to Any");
PlayerGStatsGoalieRating08.Add("James Reimer","Save, to LD");
PlayerGStatsGoalieRating08.Add("Zachary Sawchenko","Save, to LD");
PlayerGStatsGoalieRating08.Add("Jordan Binnington","Save, to RW");
PlayerGStatsGoalieRating08.Add("Jon Gillies","Save, to LW");
PlayerGStatsGoalieRating08.Add("Thomas Greiss","Save, to LW");
PlayerGStatsGoalieRating08.Add("Joel Hofer","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating08.Add("Hugo Alnefelt","Save, to RD");
PlayerGStatsGoalieRating08.Add("Brian Elliott","Save, to RW");
PlayerGStatsGoalieRating08.Add("Maxime Lagace","Goal");
PlayerGStatsGoalieRating08.Add("Alexei Melnichuk","Save, to Any");
PlayerGStatsGoalieRating08.Add("Andrei Vasilevskiy","Save, to RD");
PlayerGStatsGoalieRating08.Add("Michael Hutchinson","Save, to C");
PlayerGStatsGoalieRating08.Add("Carter Hutton","Save, to RW");
PlayerGStatsGoalieRating08.Add("Erik Kallgren","Goal");
PlayerGStatsGoalieRating08.Add("Matt Murray","Save, to C");
PlayerGStatsGoalieRating08.Add("Ilya Samsonov","Save, to C");
PlayerGStatsGoalieRating08.Add("Joseph Woll","Save, to RD");
PlayerGStatsGoalieRating08.Add("Thatcher Demko","Save, to LW");
PlayerGStatsGoalieRating08.Add("Michael DiPietro","Breakaway");
PlayerGStatsGoalieRating08.Add("Spencer Martin","Save, to Any");
PlayerGStatsGoalieRating08.Add("Laurent Brossoit","Save, to RD");
PlayerGStatsGoalieRating08.Add("Robin Lehner","Breakaway");
PlayerGStatsGoalieRating08.Add("Logan Thompson","Save, to RW");
PlayerGStatsGoalieRating08.Add("Zachary Fucale","Save, to LW");
PlayerGStatsGoalieRating08.Add("Darcy Kuemper","Save, to Any");
PlayerGStatsGoalieRating08.Add("Charlie Lindgren","Save, to C");
PlayerGStatsGoalieRating08.Add("Connor Hellebuyck","Save, to Any");
PlayerGStatsGoalieRating08.Add("David Rittich","Save, to LW");

FrPlayerGStatsGoalieRating08.Add("John GibsonANA","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("JeanSebastian GiguereANA","Penalty");
FrPlayerGStatsGoalieRating08.Add("Guy HebertANA","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Jonas HillerANA","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Johan HedbergATL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Kari LehtonenATL","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Pasi NurminenATL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Ondrej PavelecATL","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Gerry CheeversBOS","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Reggie LemelinBOS","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Andy MoogBOS","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Tuukka RaskBOS","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Dominik HasekBUF","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Clint MalarchukBUF","Goal");
FrPlayerGStatsGoalieRating08.Add("Ryan MillerBUF","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Daren PuppaBUF","Goal");
FrPlayerGStatsGoalieRating08.Add("Trevor KiddCAL","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Miikka KiprusoffCAL","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Roman TurekCAL","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Mike VernonCAL","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Arturs IrbeCAR","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Petr MrazekCAR","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Cam WardCAR","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Kevin WeekesCAR","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Sergei BobrovskyCBJ","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Marc DenisCBJ","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Pascal LeclaireCBJ","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Steve MasonCBJ","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Ed BelfourCHI","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Corey CrawfordCHI","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Tony EspositoCHI","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Glenn HallCHI","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("David AebischerCOL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Peter BudajCOL","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Patrick RoyCOL","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Semyon VarlamovCOL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Ed BelfourDAL","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Kari LehtonenDAL","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Andy MoogDAL","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Marty TurcoDAL","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Tim CheveldaeDET","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Jimmy HowardDET","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Chris OsgoodDET","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Terry SawchukDET","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Grant FuhrEDM","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Andy MoogEDM","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Bill RanfordEDM","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Tommy SaloEDM","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Sean BurkeFLA","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Roberto LuongoFLA","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("John VanbiesbrouckFLA","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Tomas VokounFLA","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Sean BurkeHAR","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Mike LiutHAR","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Greg MillenHAR","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Peter SidorkiewiczHAR","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Stephane FisetLAK","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Kelly HrudeyLAK","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Jonathan QuickLAK","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Rogatien VachonLAK","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Don BeaupreMNS","Rebound");
FrPlayerGStatsGoalieRating08.Add("Jon CaseyMNS","Goal");
FrPlayerGStatsGoalieRating08.Add("Cesare ManiagoMNS","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Gilles MelocheMNS","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Niklas BackstromMNW","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Devan DubnykMNW","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Manny FernandezMNW","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Dwayne RolosonMNW","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Ken DrydenMON","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Jacques PlanteMON","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Carey PriceMON","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Patrick RoyMON","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Mike DunhamNAS","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Chris MasonNAS","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Pekka RinneNAS","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Tomas VokounNAS","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Martin BrodeurNJD","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Chico ReschNJD","Rebound");
FrPlayerGStatsGoalieRating08.Add("Cory SchneiderNJD","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Chris TerreriNJD","Goal");
FrPlayerGStatsGoalieRating08.Add("Rick DiPietroNYI","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Kelly HrudeyNYI","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Chico ReschNYI","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Billy SmithNYI","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating08.Add("Eddie GiacominNYR","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Henrik LundqvistNYR","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Mike RichterNYR","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Gump WorsleyNYR","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Craig AndersonOTT","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Patrick LalimeOTT","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Damian RhodesOTT","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Ron TugnuttOTT","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Brian BoucherPHI","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Ron HextallPHI","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating08.Add("Pelle LindberghPHI","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Bernie ParentPHI","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Ilya BryzgalovPHO","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Sean BurkePHO","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Nikolai KhabibulinPHO","Penalty");
FrPlayerGStatsGoalieRating08.Add("Mike SmithPHO","Penalty");
FrPlayerGStatsGoalieRating08.Add("Tom BarrassoPIT","Goal");
FrPlayerGStatsGoalieRating08.Add("MarcAndre FleuryPIT","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Denis HerronPIT","Rebound");
FrPlayerGStatsGoalieRating08.Add("Ken WreggetPIT","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Dan BouchardQUE","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Stephane FisetQUE","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating08.Add("Mario GosselinQUE","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Ron TugnuttQUE","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Arturs IrbeSJS","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating08.Add("Martin JonesSJS","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Evgeni NabokovSJS","Penalty");
FrPlayerGStatsGoalieRating08.Add("Antti NiemiSJS","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Jake AllenSTL","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Grant FuhrSTL","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Curtis JosephSTL","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Mike LiutSTL","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Ben BishopTBL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Nikolai KhabibulinTBL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Daren PuppaTBL","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Andrei VasilevskiyTBL","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Johnny BowerTOR","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Turk BrodaTOR","Save, to LD");
FrPlayerGStatsGoalieRating08.Add("Curtis JosephTOR","Save, to RD");
FrPlayerGStatsGoalieRating08.Add("Felix PotvinTOR","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Richard BrodeurVAN","Rebound");
FrPlayerGStatsGoalieRating08.Add("Dan CloutierVAN","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Roberto LuongoVAN","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Kirk McLeanVAN","Save, to LW");
FrPlayerGStatsGoalieRating08.Add("Don BeaupreWAS","Save, to RW");
FrPlayerGStatsGoalieRating08.Add("Braden HoltbyWAS","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Al JensenWAS","Breakaway");
FrPlayerGStatsGoalieRating08.Add("Olaf KolzigWAS","Save, to Any");
FrPlayerGStatsGoalieRating08.Add("Bob EssensaWPG","Goal");
FrPlayerGStatsGoalieRating08.Add("Brian HaywardWPG","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating08.Add("Connor HellebuyckWPG","Save, to C");
FrPlayerGStatsGoalieRating08.Add("Ondrej PavelecWPG","Breakaway");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}