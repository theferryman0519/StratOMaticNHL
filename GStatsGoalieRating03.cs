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

public class GStatsGoalieRating03 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating03 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating03 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating03.Add("Lukas Dostal","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("John Gibson","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Thomas Hodges","Goal");
PlayerGStatsGoalieRating03.Add("Anthony Stolarz","Rebound");
PlayerGStatsGoalieRating03.Add("Josef Korenar","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Ivan Prosvetov","Save, to LD");
PlayerGStatsGoalieRating03.Add("Harri Sateri","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Karel Vejmelka","Breakaway");
PlayerGStatsGoalieRating03.Add("Troy Grosenick","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Jeremy Swayman","Breakaway");
PlayerGStatsGoalieRating03.Add("Linus Ullmark","Save, to C");
PlayerGStatsGoalieRating03.Add("Craig Anderson","Rebound");
PlayerGStatsGoalieRating03.Add("Eric Comrie","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Michael Houser","Breakaway");
PlayerGStatsGoalieRating03.Add("UkkoPekka Luukkonen","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Malcolm Subban","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Dustin Tokarski","Save, to C");
PlayerGStatsGoalieRating03.Add("Jacob Markstrom","Save, to LW");
PlayerGStatsGoalieRating03.Add("Daniel Vladar","Breakaway");
PlayerGStatsGoalieRating03.Add("Adam Werner","Breakaway");
PlayerGStatsGoalieRating03.Add("Frederik Andersen","Save, to LW");
PlayerGStatsGoalieRating03.Add("Pyotr Kochetkov","Breakaway");
PlayerGStatsGoalieRating03.Add("Jack LaFontaine","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Alex Lyon","Breakaway");
PlayerGStatsGoalieRating03.Add("Antti Raanta","Save, to RD");
PlayerGStatsGoalieRating03.Add("JeanFrancois Berube","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Joonas Korpisalo","Rebound");
PlayerGStatsGoalieRating03.Add("Elvis Merzlikins","Save, to Any");
PlayerGStatsGoalieRating03.Add("Daniil Tarasov","Breakaway");
PlayerGStatsGoalieRating03.Add("Collin Delia","Breakaway");
PlayerGStatsGoalieRating03.Add("Kevin Lankinen","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating03.Add("Petr Mrazek","Save, to RD");
PlayerGStatsGoalieRating03.Add("Arvid Soderblom","Save, to C");
PlayerGStatsGoalieRating03.Add("Alex Stalock","Save, to RD");
PlayerGStatsGoalieRating03.Add("Justus Annunen","Save, to Any");
PlayerGStatsGoalieRating03.Add("Pavel Francouz","Save, to Any");
PlayerGStatsGoalieRating03.Add("Alexandar Georgiev","Save, to C");
PlayerGStatsGoalieRating03.Add("Hunter Miska","Breakaway");
PlayerGStatsGoalieRating03.Add("Landon Bow","Breakaway");
PlayerGStatsGoalieRating03.Add("Braden Holtby","Rebound");
PlayerGStatsGoalieRating03.Add("Anton Khudobin","Save, to LD");
PlayerGStatsGoalieRating03.Add("Jake Oettinger","Rebound");
PlayerGStatsGoalieRating03.Add("Scott Wedgewood","Breakaway");
PlayerGStatsGoalieRating03.Add("Kaden Fulcher","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Magnus Hellberg","Save, to Any");
PlayerGStatsGoalieRating03.Add("Ville Husso","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Alex Nedeljkovic","Goal");
PlayerGStatsGoalieRating03.Add("Jack Campbell","Save, to RD");
PlayerGStatsGoalieRating03.Add("Mikko Koskinen","Save, to RW");
PlayerGStatsGoalieRating03.Add("Calvin Pickard","Goal");
PlayerGStatsGoalieRating03.Add("Stuart Skinner","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating03.Add("Mike Smith","Save, to LW");
PlayerGStatsGoalieRating03.Add("Sergei Bobrovsky","Breakaway");
PlayerGStatsGoalieRating03.Add("Christopher Gibson","Breakaway");
PlayerGStatsGoalieRating03.Add("Jonas Johansson","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Spencer Knight","Breakaway");
PlayerGStatsGoalieRating03.Add("Pheonix Copley","Rebound");
PlayerGStatsGoalieRating03.Add("Cal Petersen","Rebound");
PlayerGStatsGoalieRating03.Add("Jonathan Quick","Save, to RD");
PlayerGStatsGoalieRating03.Add("Garret Sparks","Breakaway");
PlayerGStatsGoalieRating03.Add("MarcAndre Fleury","Save, to LD");
PlayerGStatsGoalieRating03.Add("Filip Gustavsson","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Jake Allen","Breakaway");
PlayerGStatsGoalieRating03.Add("Andrew Hammond","Breakaway");
PlayerGStatsGoalieRating03.Add("Michael McNiven","Breakaway");
PlayerGStatsGoalieRating03.Add("Samuel Montembeault","Rebound");
PlayerGStatsGoalieRating03.Add("Carey Price","Breakaway");
PlayerGStatsGoalieRating03.Add("Cayden Primeau","Breakaway");
PlayerGStatsGoalieRating03.Add("Connor Ingram","Breakaway");
PlayerGStatsGoalieRating03.Add("Juuse Saros","Save, to Any");
PlayerGStatsGoalieRating03.Add("Jonathan Bernier","Save, to C");
PlayerGStatsGoalieRating03.Add("Mackenzie Blackwood","Rebound");
PlayerGStatsGoalieRating03.Add("Nico Daws","Breakaway");
PlayerGStatsGoalieRating03.Add("Akira Schmid","Breakaway");
PlayerGStatsGoalieRating03.Add("Gilles Senn","Breakaway");
PlayerGStatsGoalieRating03.Add("Vitek Vanecek","Breakaway");
PlayerGStatsGoalieRating03.Add("Cory Schneider","Rebound");
PlayerGStatsGoalieRating03.Add("Ilya Sorokin","Breakaway");
PlayerGStatsGoalieRating03.Add("Semyon Varlamov","Save, to RW");
PlayerGStatsGoalieRating03.Add("Louis Domingue","Save, to RD");
PlayerGStatsGoalieRating03.Add("Jaroslav Halak","Save, to RD");
PlayerGStatsGoalieRating03.Add("Adam Huska","Breakaway");
PlayerGStatsGoalieRating03.Add("Keith Kinkaid","Breakaway");
PlayerGStatsGoalieRating03.Add("Igor Shesterkin","Rebound");
PlayerGStatsGoalieRating03.Add("Anton Forsberg","Breakaway");
PlayerGStatsGoalieRating03.Add("Mads Sogaard","Save, to RW");
PlayerGStatsGoalieRating03.Add("Cam Talbot","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Carter Hart","Save, to RW");
PlayerGStatsGoalieRating03.Add("Felix Sandstrom","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Casey DeSmith","Goal");
PlayerGStatsGoalieRating03.Add("Tristan Jarry","Save, to RW");
PlayerGStatsGoalieRating03.Add("Antoine Bibeau","Breakaway");
PlayerGStatsGoalieRating03.Add("Joey Daccord","Save, to RW");
PlayerGStatsGoalieRating03.Add("Chris Driedger","Goal");
PlayerGStatsGoalieRating03.Add("Philipp Grubauer","Save, to C");
PlayerGStatsGoalieRating03.Add("Martin Jones","Rebound");
PlayerGStatsGoalieRating03.Add("Aaron Dell","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Adin Hill","Breakaway");
PlayerGStatsGoalieRating03.Add("Kaapo Kahkonen","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("James Reimer","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Zachary Sawchenko","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Jordan Binnington","Save, to RW");
PlayerGStatsGoalieRating03.Add("Jon Gillies","Breakaway");
PlayerGStatsGoalieRating03.Add("Thomas Greiss","Save, to Any");
PlayerGStatsGoalieRating03.Add("Joel Hofer","Breakaway");
PlayerGStatsGoalieRating03.Add("Hugo Alnefelt","Breakaway");
PlayerGStatsGoalieRating03.Add("Brian Elliott","Rebound");
PlayerGStatsGoalieRating03.Add("Maxime Lagace","Breakaway");
PlayerGStatsGoalieRating03.Add("Alexei Melnichuk","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating03.Add("Andrei Vasilevskiy","Goal");
PlayerGStatsGoalieRating03.Add("Michael Hutchinson","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Carter Hutton","Rebound");
PlayerGStatsGoalieRating03.Add("Erik Kallgren","Breakaway");
PlayerGStatsGoalieRating03.Add("Matt Murray","Rebound");
PlayerGStatsGoalieRating03.Add("Ilya Samsonov","Rebound");
PlayerGStatsGoalieRating03.Add("Joseph Woll","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Thatcher Demko","Save, to RW");
PlayerGStatsGoalieRating03.Add("Michael DiPietro","Save, to C");
PlayerGStatsGoalieRating03.Add("Spencer Martin","OUT: Breakaway / IRB: Rebound");
PlayerGStatsGoalieRating03.Add("Laurent Brossoit","OUT: Rebound / IRB: Breakaway");
PlayerGStatsGoalieRating03.Add("Robin Lehner","Save, to C");
PlayerGStatsGoalieRating03.Add("Logan Thompson","Breakaway");
PlayerGStatsGoalieRating03.Add("Zachary Fucale","Rebound");
PlayerGStatsGoalieRating03.Add("Darcy Kuemper","Penalty");
PlayerGStatsGoalieRating03.Add("Charlie Lindgren","Goal");
PlayerGStatsGoalieRating03.Add("Connor Hellebuyck","Save, to C");
PlayerGStatsGoalieRating03.Add("David Rittich","Rebound");

FrPlayerGStatsGoalieRating03.Add("John GibsonANA","Rebound");
FrPlayerGStatsGoalieRating03.Add("JeanSebastian GiguereANA","Rebound");
FrPlayerGStatsGoalieRating03.Add("Guy HebertANA","Rebound");
FrPlayerGStatsGoalieRating03.Add("Jonas HillerANA","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Johan HedbergATL","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Kari LehtonenATL","Rebound");
FrPlayerGStatsGoalieRating03.Add("Pasi NurminenATL","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Ondrej PavelecATL","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Gerry CheeversBOS","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Reggie LemelinBOS","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Andy MoogBOS","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Tuukka RaskBOS","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Dominik HasekBUF","Goal");
FrPlayerGStatsGoalieRating03.Add("Clint MalarchukBUF","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Ryan MillerBUF","Rebound");
FrPlayerGStatsGoalieRating03.Add("Daren PuppaBUF","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Trevor KiddCAL","Penalty");
FrPlayerGStatsGoalieRating03.Add("Miikka KiprusoffCAL","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Roman TurekCAL","Rebound");
FrPlayerGStatsGoalieRating03.Add("Mike VernonCAL","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Arturs IrbeCAR","Rebound");
FrPlayerGStatsGoalieRating03.Add("Petr MrazekCAR","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Cam WardCAR","Rebound");
FrPlayerGStatsGoalieRating03.Add("Kevin WeekesCAR","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating03.Add("Sergei BobrovskyCBJ","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Marc DenisCBJ","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Pascal LeclaireCBJ","Rebound");
FrPlayerGStatsGoalieRating03.Add("Steve MasonCBJ","Rebound");
FrPlayerGStatsGoalieRating03.Add("Ed BelfourCHI","Rebound");
FrPlayerGStatsGoalieRating03.Add("Corey CrawfordCHI","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Tony EspositoCHI","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Glenn HallCHI","Rebound");
FrPlayerGStatsGoalieRating03.Add("David AebischerCOL","Penalty");
FrPlayerGStatsGoalieRating03.Add("Peter BudajCOL","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Patrick RoyCOL","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Semyon VarlamovCOL","Rebound");
FrPlayerGStatsGoalieRating03.Add("Ed BelfourDAL","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Kari LehtonenDAL","Rebound");
FrPlayerGStatsGoalieRating03.Add("Andy MoogDAL","Rebound");
FrPlayerGStatsGoalieRating03.Add("Marty TurcoDAL","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Tim CheveldaeDET","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Jimmy HowardDET","Rebound");
FrPlayerGStatsGoalieRating03.Add("Chris OsgoodDET","Rebound");
FrPlayerGStatsGoalieRating03.Add("Terry SawchukDET","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating03.Add("Grant FuhrEDM","Penalty");
FrPlayerGStatsGoalieRating03.Add("Andy MoogEDM","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Bill RanfordEDM","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Tommy SaloEDM","Rebound");
FrPlayerGStatsGoalieRating03.Add("Sean BurkeFLA","Rebound");
FrPlayerGStatsGoalieRating03.Add("Roberto LuongoFLA","Rebound");
FrPlayerGStatsGoalieRating03.Add("John VanbiesbrouckFLA","Rebound");
FrPlayerGStatsGoalieRating03.Add("Tomas VokounFLA","OUT: Rebound / IRB: Goal");
FrPlayerGStatsGoalieRating03.Add("Sean BurkeHAR","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Mike LiutHAR","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Greg MillenHAR","Goal");
FrPlayerGStatsGoalieRating03.Add("Peter SidorkiewiczHAR","Goal");
FrPlayerGStatsGoalieRating03.Add("Stephane FisetLAK","Rebound");
FrPlayerGStatsGoalieRating03.Add("Kelly HrudeyLAK","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Jonathan QuickLAK","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Rogatien VachonLAK","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Don BeaupreMNS","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Jon CaseyMNS","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Cesare ManiagoMNS","Breakaway");
FrPlayerGStatsGoalieRating03.Add("Gilles MelocheMNS","Penalty");
FrPlayerGStatsGoalieRating03.Add("Niklas BackstromMNW","Rebound");
FrPlayerGStatsGoalieRating03.Add("Devan DubnykMNW","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Manny FernandezMNW","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating03.Add("Dwayne RolosonMNW","Penalty");
FrPlayerGStatsGoalieRating03.Add("Ken DrydenMON","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Jacques PlanteMON","OUT: Breakaway / IRB: Penalty");
FrPlayerGStatsGoalieRating03.Add("Carey PriceMON","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Patrick RoyMON","Rebound");
FrPlayerGStatsGoalieRating03.Add("Mike DunhamNAS","Rebound");
FrPlayerGStatsGoalieRating03.Add("Chris MasonNAS","Rebound");
FrPlayerGStatsGoalieRating03.Add("Pekka RinneNAS","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Tomas VokounNAS","Rebound");
FrPlayerGStatsGoalieRating03.Add("Martin BrodeurNJD","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Chico ReschNJD","Goal");
FrPlayerGStatsGoalieRating03.Add("Cory SchneiderNJD","Rebound");
FrPlayerGStatsGoalieRating03.Add("Chris TerreriNJD","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Rick DiPietroNYI","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Kelly HrudeyNYI","Goal");
FrPlayerGStatsGoalieRating03.Add("Chico ReschNYI","Rebound");
FrPlayerGStatsGoalieRating03.Add("Billy SmithNYI","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Eddie GiacominNYR","Penalty");
FrPlayerGStatsGoalieRating03.Add("Henrik LundqvistNYR","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Mike RichterNYR","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Gump WorsleyNYR","Breakaway");
FrPlayerGStatsGoalieRating03.Add("Craig AndersonOTT","Rebound");
FrPlayerGStatsGoalieRating03.Add("Patrick LalimeOTT","Penalty");
FrPlayerGStatsGoalieRating03.Add("Damian RhodesOTT","Rebound");
FrPlayerGStatsGoalieRating03.Add("Ron TugnuttOTT","Rebound");
FrPlayerGStatsGoalieRating03.Add("Brian BoucherPHI","Rebound");
FrPlayerGStatsGoalieRating03.Add("Ron HextallPHI","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Pelle LindberghPHI","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Bernie ParentPHI","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Ilya BryzgalovPHO","Rebound");
FrPlayerGStatsGoalieRating03.Add("Sean BurkePHO","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Nikolai KhabibulinPHO","Rebound");
FrPlayerGStatsGoalieRating03.Add("Mike SmithPHO","Rebound");
FrPlayerGStatsGoalieRating03.Add("Tom BarrassoPIT","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("MarcAndre FleuryPIT","Rebound");
FrPlayerGStatsGoalieRating03.Add("Denis HerronPIT","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Ken WreggetPIT","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Dan BouchardQUE","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Stephane FisetQUE","Penalty");
FrPlayerGStatsGoalieRating03.Add("Mario GosselinQUE","Goal");
FrPlayerGStatsGoalieRating03.Add("Ron TugnuttQUE","Goal");
FrPlayerGStatsGoalieRating03.Add("Arturs IrbeSJS","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Martin JonesSJS","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating03.Add("Evgeni NabokovSJS","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Antti NiemiSJS","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Jake AllenSTL","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Grant FuhrSTL","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating03.Add("Curtis JosephSTL","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Mike LiutSTL","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Ben BishopTBL","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Nikolai KhabibulinTBL","Penalty");
FrPlayerGStatsGoalieRating03.Add("Daren PuppaTBL","Rebound");
FrPlayerGStatsGoalieRating03.Add("Andrei VasilevskiyTBL","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Johnny BowerTOR","OUT: Goal / IRB: Rebound");
FrPlayerGStatsGoalieRating03.Add("Turk BrodaTOR","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating03.Add("Curtis JosephTOR","Penalty");
FrPlayerGStatsGoalieRating03.Add("Felix PotvinTOR","Save, to RW");
FrPlayerGStatsGoalieRating03.Add("Richard BrodeurVAN","Goal");
FrPlayerGStatsGoalieRating03.Add("Dan CloutierVAN","Save, to RD");
FrPlayerGStatsGoalieRating03.Add("Roberto LuongoVAN","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Kirk McLeanVAN","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Don BeaupreWAS","Save, to LD");
FrPlayerGStatsGoalieRating03.Add("Braden HoltbyWAS","Save, to LW");
FrPlayerGStatsGoalieRating03.Add("Al JensenWAS","Save, to Any");
FrPlayerGStatsGoalieRating03.Add("Olaf KolzigWAS","Rebound");
FrPlayerGStatsGoalieRating03.Add("Bob EssensaWPG","Save, to C");
FrPlayerGStatsGoalieRating03.Add("Brian HaywardWPG","Goal");
FrPlayerGStatsGoalieRating03.Add("Connor HellebuyckWPG","Rebound");
FrPlayerGStatsGoalieRating03.Add("Ondrej PavelecWPG","Rebound");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}