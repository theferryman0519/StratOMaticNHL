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

public class GStatsGoalieRating11 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating11 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating11 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating11.Add("Lukas Dostal","Rebound");
PlayerGStatsGoalieRating11.Add("John Gibson","Save, to RD");
PlayerGStatsGoalieRating11.Add("Thomas Hodges","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Anthony Stolarz","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("Josef Korenar","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Ivan Prosvetov","OUT: Breakaway / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Harri Sateri","Save, to LW");
PlayerGStatsGoalieRating11.Add("Karel Vejmelka","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("Troy Grosenick","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Jeremy Swayman","Penalty");
PlayerGStatsGoalieRating11.Add("Linus Ullmark","Save, to LW");
PlayerGStatsGoalieRating11.Add("Craig Anderson","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Eric Comrie","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Michael Houser","Penalty");
PlayerGStatsGoalieRating11.Add("UkkoPekka Luukkonen","Penalty");
PlayerGStatsGoalieRating11.Add("Malcolm Subban","Rebound");
PlayerGStatsGoalieRating11.Add("Dustin Tokarski","OUT: Breakaway / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Jacob Markstrom","Save, to Any");
PlayerGStatsGoalieRating11.Add("Daniel Vladar","Penalty");
PlayerGStatsGoalieRating11.Add("Adam Werner","Penalty");
PlayerGStatsGoalieRating11.Add("Frederik Andersen","Save, to LD");
PlayerGStatsGoalieRating11.Add("Pyotr Kochetkov","Penalty");
PlayerGStatsGoalieRating11.Add("Jack LaFontaine","Penalty");
PlayerGStatsGoalieRating11.Add("Alex Lyon","Penalty");
PlayerGStatsGoalieRating11.Add("Antti Raanta","Save, to Any");
PlayerGStatsGoalieRating11.Add("JeanFrancois Berube","Save, to C");
PlayerGStatsGoalieRating11.Add("Joonas Korpisalo","Save, to LW");
PlayerGStatsGoalieRating11.Add("Elvis Merzlikins","Save, to Any");
PlayerGStatsGoalieRating11.Add("Daniil Tarasov","Goal");
PlayerGStatsGoalieRating11.Add("Collin Delia","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Kevin Lankinen","Rebound");
PlayerGStatsGoalieRating11.Add("Petr Mrazek","Penalty");
PlayerGStatsGoalieRating11.Add("Arvid Soderblom","Penalty");
PlayerGStatsGoalieRating11.Add("Alex Stalock","Save, to Any");
PlayerGStatsGoalieRating11.Add("Justus Annunen","Rebound");
PlayerGStatsGoalieRating11.Add("Pavel Francouz","Save, to LW");
PlayerGStatsGoalieRating11.Add("Alexandar Georgiev","Breakaway");
PlayerGStatsGoalieRating11.Add("Hunter Miska","Penalty");
PlayerGStatsGoalieRating11.Add("Landon Bow","Penalty");
PlayerGStatsGoalieRating11.Add("Braden Holtby","Rebound");
PlayerGStatsGoalieRating11.Add("Anton Khudobin","Breakaway");
PlayerGStatsGoalieRating11.Add("Jake Oettinger","Save, to C");
PlayerGStatsGoalieRating11.Add("Scott Wedgewood","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Kaden Fulcher","OUT: Goal / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Magnus Hellberg","OUT: Penalty / IRB: Breakaway");
PlayerGStatsGoalieRating11.Add("Ville Husso","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("Alex Nedeljkovic","Goal");
PlayerGStatsGoalieRating11.Add("Jack Campbell","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Mikko Koskinen","Save, to Any");
PlayerGStatsGoalieRating11.Add("Calvin Pickard","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Stuart Skinner","OUT: Goal / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Mike Smith","Save, to RD");
PlayerGStatsGoalieRating11.Add("Sergei Bobrovsky","Penalty");
PlayerGStatsGoalieRating11.Add("Christopher Gibson","Penalty");
PlayerGStatsGoalieRating11.Add("Jonas Johansson","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("Spencer Knight","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Pheonix Copley","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Cal Petersen","Penalty");
PlayerGStatsGoalieRating11.Add("Jonathan Quick","Save, to C");
PlayerGStatsGoalieRating11.Add("Garret Sparks","Penalty");
PlayerGStatsGoalieRating11.Add("MarcAndre Fleury","Save, to LW");
PlayerGStatsGoalieRating11.Add("Filip Gustavsson","Penalty");
PlayerGStatsGoalieRating11.Add("Jake Allen","Save, to C");
PlayerGStatsGoalieRating11.Add("Andrew Hammond","Penalty");
PlayerGStatsGoalieRating11.Add("Michael McNiven","Penalty");
PlayerGStatsGoalieRating11.Add("Samuel Montembeault","OUT: Rebound / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Carey Price","Save, to LD");
PlayerGStatsGoalieRating11.Add("Cayden Primeau","Penalty");
PlayerGStatsGoalieRating11.Add("Connor Ingram","Penalty");
PlayerGStatsGoalieRating11.Add("Juuse Saros","Save, to LD");
PlayerGStatsGoalieRating11.Add("Jonathan Bernier","Rebound");
PlayerGStatsGoalieRating11.Add("Mackenzie Blackwood","Save, to C");
PlayerGStatsGoalieRating11.Add("Nico Daws","Goal");
PlayerGStatsGoalieRating11.Add("Akira Schmid","Penalty");
PlayerGStatsGoalieRating11.Add("Gilles Senn","Penalty");
PlayerGStatsGoalieRating11.Add("Vitek Vanecek","Penalty");
PlayerGStatsGoalieRating11.Add("Cory Schneider","Penalty");
PlayerGStatsGoalieRating11.Add("Ilya Sorokin","OUT: Goal / IRB: Penalty");
PlayerGStatsGoalieRating11.Add("Semyon Varlamov","Save, to C");
PlayerGStatsGoalieRating11.Add("Louis Domingue","Rebound");
PlayerGStatsGoalieRating11.Add("Jaroslav Halak","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Adam Huska","Penalty");
PlayerGStatsGoalieRating11.Add("Keith Kinkaid","Penalty");
PlayerGStatsGoalieRating11.Add("Igor Shesterkin","Save, to LD");
PlayerGStatsGoalieRating11.Add("Anton Forsberg","Penalty");
PlayerGStatsGoalieRating11.Add("Mads Sogaard","Rebound");
PlayerGStatsGoalieRating11.Add("Cam Talbot","Save, to C");
PlayerGStatsGoalieRating11.Add("Carter Hart","Save, to RW");
PlayerGStatsGoalieRating11.Add("Felix Sandstrom","Penalty");
PlayerGStatsGoalieRating11.Add("Casey DeSmith","Goal");
PlayerGStatsGoalieRating11.Add("Tristan Jarry","Penalty");
PlayerGStatsGoalieRating11.Add("Antoine Bibeau","Penalty");
PlayerGStatsGoalieRating11.Add("Joey Daccord","Penalty");
PlayerGStatsGoalieRating11.Add("Chris Driedger","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Philipp Grubauer","Save, to LD");
PlayerGStatsGoalieRating11.Add("Martin Jones","Save, to LW");
PlayerGStatsGoalieRating11.Add("Aaron Dell","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("Adin Hill","Save, to LW");
PlayerGStatsGoalieRating11.Add("Kaapo Kahkonen","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("James Reimer","Save, to Any");
PlayerGStatsGoalieRating11.Add("Zachary Sawchenko","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating11.Add("Jordan Binnington","Save, to RD");
PlayerGStatsGoalieRating11.Add("Jon Gillies","Penalty");
PlayerGStatsGoalieRating11.Add("Thomas Greiss","Save, to LD");
PlayerGStatsGoalieRating11.Add("Joel Hofer","Penalty");
PlayerGStatsGoalieRating11.Add("Hugo Alnefelt","Penalty");
PlayerGStatsGoalieRating11.Add("Brian Elliott","Penalty");
PlayerGStatsGoalieRating11.Add("Maxime Lagace","Penalty");
PlayerGStatsGoalieRating11.Add("Alexei Melnichuk","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Andrei Vasilevskiy","Goal");
PlayerGStatsGoalieRating11.Add("Michael Hutchinson","Penalty");
PlayerGStatsGoalieRating11.Add("Carter Hutton","Rebound");
PlayerGStatsGoalieRating11.Add("Erik Kallgren","Penalty");
PlayerGStatsGoalieRating11.Add("Matt Murray","Save, to LD");
PlayerGStatsGoalieRating11.Add("Ilya Samsonov","Save, to RD");
PlayerGStatsGoalieRating11.Add("Joseph Woll","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating11.Add("Thatcher Demko","Save, to RD");
PlayerGStatsGoalieRating11.Add("Michael DiPietro","Save, to C");
PlayerGStatsGoalieRating11.Add("Spencer Martin","Penalty");
PlayerGStatsGoalieRating11.Add("Laurent Brossoit","Penalty");
PlayerGStatsGoalieRating11.Add("Robin Lehner","Goal");
PlayerGStatsGoalieRating11.Add("Logan Thompson","Penalty");
PlayerGStatsGoalieRating11.Add("Zachary Fucale","Penalty");
PlayerGStatsGoalieRating11.Add("Darcy Kuemper","Goal");
PlayerGStatsGoalieRating11.Add("Charlie Lindgren","Save, to LD");
PlayerGStatsGoalieRating11.Add("Connor Hellebuyck","Goal");
PlayerGStatsGoalieRating11.Add("David Rittich","Save, to RD");

FrPlayerGStatsGoalieRating11.Add("John GibsonANA","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("JeanSebastian GiguereANA","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Guy HebertANA","Rebound");
FrPlayerGStatsGoalieRating11.Add("Jonas HillerANA","Penalty");
FrPlayerGStatsGoalieRating11.Add("Johan HedbergATL","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Kari LehtonenATL","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating11.Add("Pasi NurminenATL","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating11.Add("Ondrej PavelecATL","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Gerry CheeversBOS","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Reggie LemelinBOS","Rebound");
FrPlayerGStatsGoalieRating11.Add("Andy MoogBOS","Breakaway");
FrPlayerGStatsGoalieRating11.Add("Tuukka RaskBOS","Goal");
FrPlayerGStatsGoalieRating11.Add("Dominik HasekBUF","Goal");
FrPlayerGStatsGoalieRating11.Add("Clint MalarchukBUF","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Ryan MillerBUF","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Daren PuppaBUF","Breakaway");
FrPlayerGStatsGoalieRating11.Add("Trevor KiddCAL","Rebound");
FrPlayerGStatsGoalieRating11.Add("Miikka KiprusoffCAL","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Roman TurekCAL","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Mike VernonCAL","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Arturs IrbeCAR","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Petr MrazekCAR","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Cam WardCAR","Rebound");
FrPlayerGStatsGoalieRating11.Add("Kevin WeekesCAR","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Sergei BobrovskyCBJ","Goal");
FrPlayerGStatsGoalieRating11.Add("Marc DenisCBJ","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating11.Add("Pascal LeclaireCBJ","Rebound");
FrPlayerGStatsGoalieRating11.Add("Steve MasonCBJ","Rebound");
FrPlayerGStatsGoalieRating11.Add("Ed BelfourCHI","Rebound");
FrPlayerGStatsGoalieRating11.Add("Corey CrawfordCHI","Goal");
FrPlayerGStatsGoalieRating11.Add("Tony EspositoCHI","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Glenn HallCHI","Rebound");
FrPlayerGStatsGoalieRating11.Add("David AebischerCOL","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Peter BudajCOL","Rebound");
FrPlayerGStatsGoalieRating11.Add("Patrick RoyCOL","Goal");
FrPlayerGStatsGoalieRating11.Add("Semyon VarlamovCOL","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Ed BelfourDAL","Penalty");
FrPlayerGStatsGoalieRating11.Add("Kari LehtonenDAL","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Andy MoogDAL","Rebound");
FrPlayerGStatsGoalieRating11.Add("Marty TurcoDAL","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Tim CheveldaeDET","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Jimmy HowardDET","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Chris OsgoodDET","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Terry SawchukDET","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Grant FuhrEDM","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Andy MoogEDM","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Bill RanfordEDM","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Tommy SaloEDM","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Sean BurkeFLA","Rebound");
FrPlayerGStatsGoalieRating11.Add("Roberto LuongoFLA","Goal");
FrPlayerGStatsGoalieRating11.Add("John VanbiesbrouckFLA","Rebound");
FrPlayerGStatsGoalieRating11.Add("Tomas VokounFLA","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating11.Add("Sean BurkeHAR","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating11.Add("Mike LiutHAR","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Greg MillenHAR","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating11.Add("Peter SidorkiewiczHAR","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Stephane FisetLAK","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating11.Add("Kelly HrudeyLAK","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Jonathan QuickLAK","Penalty");
FrPlayerGStatsGoalieRating11.Add("Rogatien VachonLAK","Rebound");
FrPlayerGStatsGoalieRating11.Add("Don BeaupreMNS","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Jon CaseyMNS","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Cesare ManiagoMNS","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Gilles MelocheMNS","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Niklas BackstromMNW","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Devan DubnykMNW","Goal");
FrPlayerGStatsGoalieRating11.Add("Manny FernandezMNW","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Dwayne RolosonMNW","Goal");
FrPlayerGStatsGoalieRating11.Add("Ken DrydenMON","Goal");
FrPlayerGStatsGoalieRating11.Add("Jacques PlanteMON","Goal");
FrPlayerGStatsGoalieRating11.Add("Carey PriceMON","Goal");
FrPlayerGStatsGoalieRating11.Add("Patrick RoyMON","Rebound");
FrPlayerGStatsGoalieRating11.Add("Mike DunhamNAS","Rebound");
FrPlayerGStatsGoalieRating11.Add("Chris MasonNAS","Rebound");
FrPlayerGStatsGoalieRating11.Add("Pekka RinneNAS","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating11.Add("Tomas VokounNAS","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Martin BrodeurNJD","Penalty");
FrPlayerGStatsGoalieRating11.Add("Chico ReschNJD","Goal");
FrPlayerGStatsGoalieRating11.Add("Cory SchneiderNJD","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Chris TerreriNJD","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Rick DiPietroNYI","Rebound");
FrPlayerGStatsGoalieRating11.Add("Kelly HrudeyNYI","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Chico ReschNYI","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating11.Add("Billy SmithNYI","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Eddie GiacominNYR","Rebound");
FrPlayerGStatsGoalieRating11.Add("Henrik LundqvistNYR","Goal");
FrPlayerGStatsGoalieRating11.Add("Mike RichterNYR","Rebound");
FrPlayerGStatsGoalieRating11.Add("Gump WorsleyNYR","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Craig AndersonOTT","Rebound");
FrPlayerGStatsGoalieRating11.Add("Patrick LalimeOTT","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Damian RhodesOTT","Rebound");
FrPlayerGStatsGoalieRating11.Add("Ron TugnuttOTT","Penalty");
FrPlayerGStatsGoalieRating11.Add("Brian BoucherPHI","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Ron HextallPHI","Rebound");
FrPlayerGStatsGoalieRating11.Add("Pelle LindberghPHI","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Bernie ParentPHI","Goal");
FrPlayerGStatsGoalieRating11.Add("Ilya BryzgalovPHO","Goal");
FrPlayerGStatsGoalieRating11.Add("Sean BurkePHO","Goal");
FrPlayerGStatsGoalieRating11.Add("Nikolai KhabibulinPHO","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Mike SmithPHO","Rebound");
FrPlayerGStatsGoalieRating11.Add("Tom BarrassoPIT","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("MarcAndre FleuryPIT","Penalty");
FrPlayerGStatsGoalieRating11.Add("Denis HerronPIT","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Ken WreggetPIT","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Dan BouchardQUE","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Stephane FisetQUE","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Mario GosselinQUE","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating11.Add("Ron TugnuttQUE","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Arturs IrbeSJS","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Martin JonesSJS","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Evgeni NabokovSJS","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Antti NiemiSJS","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Jake AllenSTL","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Grant FuhrSTL","Rebound");
FrPlayerGStatsGoalieRating11.Add("Curtis JosephSTL","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating11.Add("Mike LiutSTL","Save, to RD");
FrPlayerGStatsGoalieRating11.Add("Ben BishopTBL","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating11.Add("Nikolai KhabibulinTBL","Save, to RW");
FrPlayerGStatsGoalieRating11.Add("Daren PuppaTBL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating11.Add("Andrei VasilevskiyTBL","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating11.Add("Johnny BowerTOR","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating11.Add("Turk BrodaTOR","Rebound");
FrPlayerGStatsGoalieRating11.Add("Curtis JosephTOR","Save, to LW");
FrPlayerGStatsGoalieRating11.Add("Felix PotvinTOR","Rebound");
FrPlayerGStatsGoalieRating11.Add("Richard BrodeurVAN","Goal");
FrPlayerGStatsGoalieRating11.Add("Dan CloutierVAN","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Roberto LuongoVAN","Goal");
FrPlayerGStatsGoalieRating11.Add("Kirk McLeanVAN","Breakaway");
FrPlayerGStatsGoalieRating11.Add("Don BeaupreWAS","Rebound");
FrPlayerGStatsGoalieRating11.Add("Braden HoltbyWAS","Save, to LD");
FrPlayerGStatsGoalieRating11.Add("Al JensenWAS","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Olaf KolzigWAS","Rebound");
FrPlayerGStatsGoalieRating11.Add("Bob EssensaWPG","Save, to C");
FrPlayerGStatsGoalieRating11.Add("Brian HaywardWPG","Goal");
FrPlayerGStatsGoalieRating11.Add("Connor HellebuyckWPG","Save, to Any");
FrPlayerGStatsGoalieRating11.Add("Ondrej PavelecWPG","Rebound");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}