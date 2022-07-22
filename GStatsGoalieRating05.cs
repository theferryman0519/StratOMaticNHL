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

public class GStatsGoalieRating05 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating05 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating05 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating05.Add("Lukas Dostal","Goal");
PlayerGStatsGoalieRating05.Add("John Gibson","Goal");
PlayerGStatsGoalieRating05.Add("Thomas Hodges","Save, to RW");
PlayerGStatsGoalieRating05.Add("Anthony Stolarz","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating05.Add("Josef Korenar","Save, to C");
PlayerGStatsGoalieRating05.Add("Ivan Prosvetov","Save, to RW");
PlayerGStatsGoalieRating05.Add("Harri Sateri","Save, to Any");
PlayerGStatsGoalieRating05.Add("Karel Vejmelka","Save, to LW");
PlayerGStatsGoalieRating05.Add("Troy Grosenick","Save, to LD");
PlayerGStatsGoalieRating05.Add("Jeremy Swayman","Goal");
PlayerGStatsGoalieRating05.Add("Linus Ullmark","Save, to RD");
PlayerGStatsGoalieRating05.Add("Craig Anderson","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating05.Add("Eric Comrie","Goal");
PlayerGStatsGoalieRating05.Add("Michael Houser","Goal");
PlayerGStatsGoalieRating05.Add("UkkoPekka Luukkonen","Save, to C");
PlayerGStatsGoalieRating05.Add("Malcolm Subban","Save, to LW");
PlayerGStatsGoalieRating05.Add("Dustin Tokarski","Rebound");
PlayerGStatsGoalieRating05.Add("Jacob Markstrom","Save, to LW");
PlayerGStatsGoalieRating05.Add("Daniel Vladar","Save, to C");
PlayerGStatsGoalieRating05.Add("Adam Werner","Save, to RW");
PlayerGStatsGoalieRating05.Add("Frederik Andersen","Save, to RW");
PlayerGStatsGoalieRating05.Add("Pyotr Kochetkov","Save, to LD");
PlayerGStatsGoalieRating05.Add("Jack LaFontaine","Save, to LD");
PlayerGStatsGoalieRating05.Add("Alex Lyon","Save, to LD");
PlayerGStatsGoalieRating05.Add("Antti Raanta","Save, to C");
PlayerGStatsGoalieRating05.Add("JeanFrancois Berube","Save, to RW");
PlayerGStatsGoalieRating05.Add("Joonas Korpisalo","Goal");
PlayerGStatsGoalieRating05.Add("Elvis Merzlikins","Save, to LW");
PlayerGStatsGoalieRating05.Add("Daniil Tarasov","Save, to Any");
PlayerGStatsGoalieRating05.Add("Collin Delia","Goal");
PlayerGStatsGoalieRating05.Add("Kevin Lankinen","Goal");
PlayerGStatsGoalieRating05.Add("Petr Mrazek","Save, to RW");
PlayerGStatsGoalieRating05.Add("Arvid Soderblom","Save, to LW");
PlayerGStatsGoalieRating05.Add("Alex Stalock","Save, to RW");
PlayerGStatsGoalieRating05.Add("Justus Annunen","Save, to RW");
PlayerGStatsGoalieRating05.Add("Pavel Francouz","Goal");
PlayerGStatsGoalieRating05.Add("Alexandar Georgiev","Penalty");
PlayerGStatsGoalieRating05.Add("Hunter Miska","Rebound");
PlayerGStatsGoalieRating05.Add("Landon Bow","Save, to LD");
PlayerGStatsGoalieRating05.Add("Braden Holtby","Goal");
PlayerGStatsGoalieRating05.Add("Anton Khudobin","Save, to RD");
PlayerGStatsGoalieRating05.Add("Jake Oettinger","Goal");
PlayerGStatsGoalieRating05.Add("Scott Wedgewood","Save, to RW");
PlayerGStatsGoalieRating05.Add("Kaden Fulcher","Save, to RW");
PlayerGStatsGoalieRating05.Add("Magnus Hellberg","Goal");
PlayerGStatsGoalieRating05.Add("Ville Husso","Save, to LW");
PlayerGStatsGoalieRating05.Add("Alex Nedeljkovic","Save, to RW");
PlayerGStatsGoalieRating05.Add("Jack Campbell","Save, to RW");
PlayerGStatsGoalieRating05.Add("Mikko Koskinen","Goal");
PlayerGStatsGoalieRating05.Add("Calvin Pickard","Save, to LD");
PlayerGStatsGoalieRating05.Add("Stuart Skinner","Save, to RW");
PlayerGStatsGoalieRating05.Add("Mike Smith","Goal");
PlayerGStatsGoalieRating05.Add("Sergei Bobrovsky","Goal");
PlayerGStatsGoalieRating05.Add("Christopher Gibson","Save, to LW");
PlayerGStatsGoalieRating05.Add("Jonas Johansson","Save, to RW");
PlayerGStatsGoalieRating05.Add("Spencer Knight","Goal");
PlayerGStatsGoalieRating05.Add("Pheonix Copley","Save, to Any");
PlayerGStatsGoalieRating05.Add("Cal Petersen","Save, to C");
PlayerGStatsGoalieRating05.Add("Jonathan Quick","Goal");
PlayerGStatsGoalieRating05.Add("Garret Sparks","Save, to C");
PlayerGStatsGoalieRating05.Add("MarcAndre Fleury","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating05.Add("Filip Gustavsson","Goal");
PlayerGStatsGoalieRating05.Add("Jake Allen","Goal");
PlayerGStatsGoalieRating05.Add("Andrew Hammond","Rebound");
PlayerGStatsGoalieRating05.Add("Michael McNiven","Save, to LD");
PlayerGStatsGoalieRating05.Add("Samuel Montembeault","Save, to LD");
PlayerGStatsGoalieRating05.Add("Carey Price","Goal");
PlayerGStatsGoalieRating05.Add("Cayden Primeau","Save, to RW");
PlayerGStatsGoalieRating05.Add("Connor Ingram","Save, to LW");
PlayerGStatsGoalieRating05.Add("Juuse Saros","Penalty");
PlayerGStatsGoalieRating05.Add("Jonathan Bernier","Goal");
PlayerGStatsGoalieRating05.Add("Mackenzie Blackwood","Goal");
PlayerGStatsGoalieRating05.Add("Nico Daws","Save, to RW");
PlayerGStatsGoalieRating05.Add("Akira Schmid","Save, to RD");
PlayerGStatsGoalieRating05.Add("Gilles Senn","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating05.Add("Vitek Vanecek","Goal");
PlayerGStatsGoalieRating05.Add("Cory Schneider","Goal");
PlayerGStatsGoalieRating05.Add("Ilya Sorokin","Save, to LD");
PlayerGStatsGoalieRating05.Add("Semyon Varlamov","Save, to Any");
PlayerGStatsGoalieRating05.Add("Louis Domingue","Penalty");
PlayerGStatsGoalieRating05.Add("Jaroslav Halak","Save, to RW");
PlayerGStatsGoalieRating05.Add("Adam Huska","Save, to Any");
PlayerGStatsGoalieRating05.Add("Keith Kinkaid","Save, to LD");
PlayerGStatsGoalieRating05.Add("Igor Shesterkin","Penalty");
PlayerGStatsGoalieRating05.Add("Anton Forsberg","Rebound");
PlayerGStatsGoalieRating05.Add("Mads Sogaard","Save, to RD");
PlayerGStatsGoalieRating05.Add("Cam Talbot","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating05.Add("Carter Hart","Goal");
PlayerGStatsGoalieRating05.Add("Felix Sandstrom","Save, to RD");
PlayerGStatsGoalieRating05.Add("Casey DeSmith","Save, to Any");
PlayerGStatsGoalieRating05.Add("Tristan Jarry","Breakaway");
PlayerGStatsGoalieRating05.Add("Antoine Bibeau","Save, to RD");
PlayerGStatsGoalieRating05.Add("Joey Daccord","Goal");
PlayerGStatsGoalieRating05.Add("Chris Driedger","Save, to RW");
PlayerGStatsGoalieRating05.Add("Philipp Grubauer","Save, to RD");
PlayerGStatsGoalieRating05.Add("Martin Jones","Save, to RW");
PlayerGStatsGoalieRating05.Add("Aaron Dell","Save, to RD");
PlayerGStatsGoalieRating05.Add("Adin Hill","Goal");
PlayerGStatsGoalieRating05.Add("Kaapo Kahkonen","Save, to LD");
PlayerGStatsGoalieRating05.Add("James Reimer","Goal");
PlayerGStatsGoalieRating05.Add("Zachary Sawchenko","Goal");
PlayerGStatsGoalieRating05.Add("Jordan Binnington","Save, to LW");
PlayerGStatsGoalieRating05.Add("Jon Gillies","Save, to LW");
PlayerGStatsGoalieRating05.Add("Thomas Greiss","Save, to Any");
PlayerGStatsGoalieRating05.Add("Joel Hofer","Save, to C");
PlayerGStatsGoalieRating05.Add("Hugo Alnefelt","Save, to Any");
PlayerGStatsGoalieRating05.Add("Brian Elliott","Goal");
PlayerGStatsGoalieRating05.Add("Maxime Lagace","Save, to Any");
PlayerGStatsGoalieRating05.Add("Alexei Melnichuk","Save, to RD");
PlayerGStatsGoalieRating05.Add("Andrei Vasilevskiy","Save, to RW");
PlayerGStatsGoalieRating05.Add("Michael Hutchinson","Save, to LD");
PlayerGStatsGoalieRating05.Add("Carter Hutton","Penalty");
PlayerGStatsGoalieRating05.Add("Erik Kallgren","Goal");
PlayerGStatsGoalieRating05.Add("Matt Murray","Goal");
PlayerGStatsGoalieRating05.Add("Ilya Samsonov","Goal");
PlayerGStatsGoalieRating05.Add("Joseph Woll","Save, to LD");
PlayerGStatsGoalieRating05.Add("Thatcher Demko","Save, to C");
PlayerGStatsGoalieRating05.Add("Michael DiPietro","Goal");
PlayerGStatsGoalieRating05.Add("Spencer Martin","Save, to LW");
PlayerGStatsGoalieRating05.Add("Laurent Brossoit","Goal");
PlayerGStatsGoalieRating05.Add("Robin Lehner","Save, to Any");
PlayerGStatsGoalieRating05.Add("Logan Thompson","Goal");
PlayerGStatsGoalieRating05.Add("Zachary Fucale","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating05.Add("Darcy Kuemper","Penalty");
PlayerGStatsGoalieRating05.Add("Charlie Lindgren","Save, to LD");
PlayerGStatsGoalieRating05.Add("Connor Hellebuyck","Save, to C");
PlayerGStatsGoalieRating05.Add("David Rittich","Goal");

FrPlayerGStatsGoalieRating05.Add("John GibsonANA","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("JeanSebastian GiguereANA","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Guy HebertANA","Goal");
FrPlayerGStatsGoalieRating05.Add("Jonas HillerANA","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Johan HedbergATL","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Kari LehtonenATL","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Pasi NurminenATL","Goal");
FrPlayerGStatsGoalieRating05.Add("Ondrej PavelecATL","Goal");
FrPlayerGStatsGoalieRating05.Add("Gerry CheeversBOS","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Reggie LemelinBOS","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Andy MoogBOS","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Tuukka RaskBOS","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Dominik HasekBUF","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Clint MalarchukBUF","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Ryan MillerBUF","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Daren PuppaBUF","Rebound");
FrPlayerGStatsGoalieRating05.Add("Trevor KiddCAL","Penalty");
FrPlayerGStatsGoalieRating05.Add("Miikka KiprusoffCAL","Penalty");
FrPlayerGStatsGoalieRating05.Add("Roman TurekCAL","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating05.Add("Mike VernonCAL","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Arturs IrbeCAR","Goal");
FrPlayerGStatsGoalieRating05.Add("Petr MrazekCAR","Goal");
FrPlayerGStatsGoalieRating05.Add("Cam WardCAR","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating05.Add("Kevin WeekesCAR","Penalty");
FrPlayerGStatsGoalieRating05.Add("Sergei BobrovskyCBJ","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Marc DenisCBJ","Goal");
FrPlayerGStatsGoalieRating05.Add("Pascal LeclaireCBJ","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating05.Add("Steve MasonCBJ","Goal");
FrPlayerGStatsGoalieRating05.Add("Ed BelfourCHI","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating05.Add("Corey CrawfordCHI","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Tony EspositoCHI","Goal");
FrPlayerGStatsGoalieRating05.Add("Glenn HallCHI","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("David AebischerCOL","Penalty");
FrPlayerGStatsGoalieRating05.Add("Peter BudajCOL","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Patrick RoyCOL","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Semyon VarlamovCOL","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Ed BelfourDAL","Goal");
FrPlayerGStatsGoalieRating05.Add("Kari LehtonenDAL","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Andy MoogDAL","Goal");
FrPlayerGStatsGoalieRating05.Add("Marty TurcoDAL","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating05.Add("Tim CheveldaeDET","Rebound");
FrPlayerGStatsGoalieRating05.Add("Jimmy HowardDET","Penalty");
FrPlayerGStatsGoalieRating05.Add("Chris OsgoodDET","Goal");
FrPlayerGStatsGoalieRating05.Add("Terry SawchukDET","Goal");
FrPlayerGStatsGoalieRating05.Add("Grant FuhrEDM","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Andy MoogEDM","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating05.Add("Bill RanfordEDM","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating05.Add("Tommy SaloEDM","Goal");
FrPlayerGStatsGoalieRating05.Add("Sean BurkeFLA","Goal");
FrPlayerGStatsGoalieRating05.Add("Roberto LuongoFLA","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("John VanbiesbrouckFLA","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Tomas VokounFLA","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Sean BurkeHAR","Goal");
FrPlayerGStatsGoalieRating05.Add("Mike LiutHAR","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Greg MillenHAR","Penalty");
FrPlayerGStatsGoalieRating05.Add("Peter SidorkiewiczHAR","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating05.Add("Stephane FisetLAK","Goal");
FrPlayerGStatsGoalieRating05.Add("Kelly HrudeyLAK","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Jonathan QuickLAK","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Rogatien VachonLAK","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Don BeaupreMNS","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Jon CaseyMNS","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating05.Add("Cesare ManiagoMNS","OUT: Rebound / IRB: Goal");
FrPlayerGStatsGoalieRating05.Add("Gilles MelocheMNS","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Niklas BackstromMNW","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Devan DubnykMNW","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Manny FernandezMNW","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Dwayne RolosonMNW","Penalty");
FrPlayerGStatsGoalieRating05.Add("Ken DrydenMON","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Jacques PlanteMON","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Carey PriceMON","Penalty");
FrPlayerGStatsGoalieRating05.Add("Patrick RoyMON","Goal");
FrPlayerGStatsGoalieRating05.Add("Mike DunhamNAS","Goal");
FrPlayerGStatsGoalieRating05.Add("Chris MasonNAS","Goal");
FrPlayerGStatsGoalieRating05.Add("Pekka RinneNAS","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Tomas VokounNAS","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Martin BrodeurNJD","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Chico ReschNJD","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Cory SchneiderNJD","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Chris TerreriNJD","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Rick DiPietroNYI","Goal");
FrPlayerGStatsGoalieRating05.Add("Kelly HrudeyNYI","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating05.Add("Chico ReschNYI","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating05.Add("Billy SmithNYI","Rebound");
FrPlayerGStatsGoalieRating05.Add("Eddie GiacominNYR","Goal");
FrPlayerGStatsGoalieRating05.Add("Henrik LundqvistNYR","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Mike RichterNYR","Goal");
FrPlayerGStatsGoalieRating05.Add("Gump WorsleyNYR","OUT: Rebound / IRB: Goal");
FrPlayerGStatsGoalieRating05.Add("Craig AndersonOTT","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Patrick LalimeOTT","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating05.Add("Damian RhodesOTT","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Ron TugnuttOTT","Goal");
FrPlayerGStatsGoalieRating05.Add("Brian BoucherPHI","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating05.Add("Ron HextallPHI","Save, to C");
FrPlayerGStatsGoalieRating05.Add("Pelle LindberghPHI","Rebound");
FrPlayerGStatsGoalieRating05.Add("Bernie ParentPHI","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Ilya BryzgalovPHO","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Sean BurkePHO","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Nikolai KhabibulinPHO","Goal");
FrPlayerGStatsGoalieRating05.Add("Mike SmithPHO","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Tom BarrassoPIT","Rebound");
FrPlayerGStatsGoalieRating05.Add("MarcAndre FleuryPIT","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Denis HerronPIT","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Ken WreggetPIT","Rebound");
FrPlayerGStatsGoalieRating05.Add("Dan BouchardQUE","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Stephane FisetQUE","Rebound");
FrPlayerGStatsGoalieRating05.Add("Mario GosselinQUE","Rebound");
FrPlayerGStatsGoalieRating05.Add("Ron TugnuttQUE","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Arturs IrbeSJS","Rebound");
FrPlayerGStatsGoalieRating05.Add("Martin JonesSJS","Goal");
FrPlayerGStatsGoalieRating05.Add("Evgeni NabokovSJS","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Antti NiemiSJS","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Jake AllenSTL","Save, to LW");
FrPlayerGStatsGoalieRating05.Add("Grant FuhrSTL","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Curtis JosephSTL","Goal");
FrPlayerGStatsGoalieRating05.Add("Mike LiutSTL","Save, to RD");
FrPlayerGStatsGoalieRating05.Add("Ben BishopTBL","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Nikolai KhabibulinTBL","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Daren PuppaTBL","Goal");
FrPlayerGStatsGoalieRating05.Add("Andrei VasilevskiyTBL","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Johnny BowerTOR","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Turk BrodaTOR","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Curtis JosephTOR","Goal");
FrPlayerGStatsGoalieRating05.Add("Felix PotvinTOR","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating05.Add("Richard BrodeurVAN","Penalty");
FrPlayerGStatsGoalieRating05.Add("Dan CloutierVAN","Goal");
FrPlayerGStatsGoalieRating05.Add("Roberto LuongoVAN","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Kirk McLeanVAN","Rebound");
FrPlayerGStatsGoalieRating05.Add("Don BeaupreWAS","Save, to Any");
FrPlayerGStatsGoalieRating05.Add("Braden HoltbyWAS","Save, to RW");
FrPlayerGStatsGoalieRating05.Add("Al JensenWAS","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Olaf KolzigWAS","Goal");
FrPlayerGStatsGoalieRating05.Add("Bob EssensaWPG","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating05.Add("Brian HaywardWPG","Breakaway");
FrPlayerGStatsGoalieRating05.Add("Connor HellebuyckWPG","Save, to LD");
FrPlayerGStatsGoalieRating05.Add("Ondrej PavelecWPG","Goal");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}