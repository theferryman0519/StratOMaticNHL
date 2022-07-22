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

public class GStatsGoalieRating04 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating04 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating04 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating04.Add("Lukas Dostal","Penalty");
PlayerGStatsGoalieRating04.Add("John Gibson","Save, to RD");
PlayerGStatsGoalieRating04.Add("Thomas Hodges","Breakaway");
PlayerGStatsGoalieRating04.Add("Anthony Stolarz","Save, to LD");
PlayerGStatsGoalieRating04.Add("Josef Korenar","Save, to C");
PlayerGStatsGoalieRating04.Add("Ivan Prosvetov","Save, to LD");
PlayerGStatsGoalieRating04.Add("Harri Sateri","Save, to RW");
PlayerGStatsGoalieRating04.Add("Karel Vejmelka","Rebound");
PlayerGStatsGoalieRating04.Add("Troy Grosenick","Save, to RD");
PlayerGStatsGoalieRating04.Add("Jeremy Swayman","Save, to C");
PlayerGStatsGoalieRating04.Add("Linus Ullmark","Goal");
PlayerGStatsGoalieRating04.Add("Craig Anderson","Save, to RW");
PlayerGStatsGoalieRating04.Add("Eric Comrie","Save, to RD");
PlayerGStatsGoalieRating04.Add("Michael Houser","Save, to Any");
PlayerGStatsGoalieRating04.Add("UkkoPekka Luukkonen","Save, to LW");
PlayerGStatsGoalieRating04.Add("Malcolm Subban","Save, to Any");
PlayerGStatsGoalieRating04.Add("Dustin Tokarski","Save, to RD");
PlayerGStatsGoalieRating04.Add("Jacob Markstrom","Goal");
PlayerGStatsGoalieRating04.Add("Daniel Vladar","Save, to RD");
PlayerGStatsGoalieRating04.Add("Adam Werner","Goal");
PlayerGStatsGoalieRating04.Add("Frederik Andersen","Goal");
PlayerGStatsGoalieRating04.Add("Pyotr Kochetkov","Goal");
PlayerGStatsGoalieRating04.Add("Jack LaFontaine","Save, to LD");
PlayerGStatsGoalieRating04.Add("Alex Lyon","Rebound");
PlayerGStatsGoalieRating04.Add("Antti Raanta","Goal");
PlayerGStatsGoalieRating04.Add("JeanFrancois Berube","Save, to Any");
PlayerGStatsGoalieRating04.Add("Joonas Korpisalo","Save, to LW");
PlayerGStatsGoalieRating04.Add("Elvis Merzlikins","Goal");
PlayerGStatsGoalieRating04.Add("Daniil Tarasov","Goal");
PlayerGStatsGoalieRating04.Add("Collin Delia","Rebound");
PlayerGStatsGoalieRating04.Add("Kevin Lankinen","Save, to RD");
PlayerGStatsGoalieRating04.Add("Petr Mrazek","Goal");
PlayerGStatsGoalieRating04.Add("Arvid Soderblom","Save, to RW");
PlayerGStatsGoalieRating04.Add("Alex Stalock","Goal");
PlayerGStatsGoalieRating04.Add("Justus Annunen","Rebound");
PlayerGStatsGoalieRating04.Add("Pavel Francouz","Breakaway");
PlayerGStatsGoalieRating04.Add("Alexandar Georgiev","Goal");
PlayerGStatsGoalieRating04.Add("Hunter Miska","Save, to RD");
PlayerGStatsGoalieRating04.Add("Landon Bow","Rebound");
PlayerGStatsGoalieRating04.Add("Braden Holtby","Penalty");
PlayerGStatsGoalieRating04.Add("Anton Khudobin","Goal");
PlayerGStatsGoalieRating04.Add("Jake Oettinger","Penalty");
PlayerGStatsGoalieRating04.Add("Scott Wedgewood","Rebound");
PlayerGStatsGoalieRating04.Add("Kaden Fulcher","Save, to RW");
PlayerGStatsGoalieRating04.Add("Magnus Hellberg","Save, to LW");
PlayerGStatsGoalieRating04.Add("Ville Husso","Save, to C");
PlayerGStatsGoalieRating04.Add("Alex Nedeljkovic","Save, to RW");
PlayerGStatsGoalieRating04.Add("Jack Campbell","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating04.Add("Mikko Koskinen","Save, to RD");
PlayerGStatsGoalieRating04.Add("Calvin Pickard","Goal");
PlayerGStatsGoalieRating04.Add("Stuart Skinner","Save, to RD");
PlayerGStatsGoalieRating04.Add("Mike Smith","Save, to Any");
PlayerGStatsGoalieRating04.Add("Sergei Bobrovsky","Save, to LW");
PlayerGStatsGoalieRating04.Add("Christopher Gibson","Save, to RW");
PlayerGStatsGoalieRating04.Add("Jonas Johansson","Save, to Any");
PlayerGStatsGoalieRating04.Add("Spencer Knight","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating04.Add("Pheonix Copley","Save, to C");
PlayerGStatsGoalieRating04.Add("Cal Petersen","Goal");
PlayerGStatsGoalieRating04.Add("Jonathan Quick","Save, to RD");
PlayerGStatsGoalieRating04.Add("Garret Sparks","Rebound");
PlayerGStatsGoalieRating04.Add("MarcAndre Fleury","Save, to Any");
PlayerGStatsGoalieRating04.Add("Filip Gustavsson","Save, to C");
PlayerGStatsGoalieRating04.Add("Jake Allen","Save, to LD");
PlayerGStatsGoalieRating04.Add("Andrew Hammond","Save, to Any");
PlayerGStatsGoalieRating04.Add("Michael McNiven","Save, to LD");
PlayerGStatsGoalieRating04.Add("Samuel Montembeault","Save, to LW");
PlayerGStatsGoalieRating04.Add("Carey Price","Penalty");
PlayerGStatsGoalieRating04.Add("Cayden Primeau","Rebound");
PlayerGStatsGoalieRating04.Add("Connor Ingram","Save, to LD");
PlayerGStatsGoalieRating04.Add("Juuse Saros","OUT: Breakaway / IRB: Goal");
PlayerGStatsGoalieRating04.Add("Jonathan Bernier","OUT: Penalty / IRB: Rebound");
PlayerGStatsGoalieRating04.Add("Mackenzie Blackwood","Breakaway");
PlayerGStatsGoalieRating04.Add("Nico Daws","Goal");
PlayerGStatsGoalieRating04.Add("Akira Schmid","Save, to LD");
PlayerGStatsGoalieRating04.Add("Gilles Senn","Save, to C");
PlayerGStatsGoalieRating04.Add("Vitek Vanecek","Save, to RW");
PlayerGStatsGoalieRating04.Add("Cory Schneider","Save, to C");
PlayerGStatsGoalieRating04.Add("Ilya Sorokin","Goal");
PlayerGStatsGoalieRating04.Add("Semyon Varlamov","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating04.Add("Louis Domingue","Rebound");
PlayerGStatsGoalieRating04.Add("Jaroslav Halak","Goal");
PlayerGStatsGoalieRating04.Add("Adam Huska","Save, to LW");
PlayerGStatsGoalieRating04.Add("Keith Kinkaid","Rebound");
PlayerGStatsGoalieRating04.Add("Igor Shesterkin","Goal");
PlayerGStatsGoalieRating04.Add("Anton Forsberg","Save, to C");
PlayerGStatsGoalieRating04.Add("Mads Sogaard","Rebound");
PlayerGStatsGoalieRating04.Add("Cam Talbot","Save, to LW");
PlayerGStatsGoalieRating04.Add("Carter Hart","Save, to LW");
PlayerGStatsGoalieRating04.Add("Felix Sandstrom","Save, to Any");
PlayerGStatsGoalieRating04.Add("Casey DeSmith","Save, to LW");
PlayerGStatsGoalieRating04.Add("Tristan Jarry","Goal");
PlayerGStatsGoalieRating04.Add("Antoine Bibeau","Save, to LD");
PlayerGStatsGoalieRating04.Add("Joey Daccord","Save, to Any");
PlayerGStatsGoalieRating04.Add("Chris Driedger","Save, to C");
PlayerGStatsGoalieRating04.Add("Philipp Grubauer","Goal");
PlayerGStatsGoalieRating04.Add("Martin Jones","Breakaway");
PlayerGStatsGoalieRating04.Add("Aaron Dell","Save, to C");
PlayerGStatsGoalieRating04.Add("Adin Hill","Save, to RW");
PlayerGStatsGoalieRating04.Add("Kaapo Kahkonen","Save, to LW");
PlayerGStatsGoalieRating04.Add("James Reimer","Save, to LD");
PlayerGStatsGoalieRating04.Add("Zachary Sawchenko","Save, to LD");
PlayerGStatsGoalieRating04.Add("Jordan Binnington","Goal");
PlayerGStatsGoalieRating04.Add("Jon Gillies","Save, to Any");
PlayerGStatsGoalieRating04.Add("Thomas Greiss","Goal");
PlayerGStatsGoalieRating04.Add("Joel Hofer","Save, to RW");
PlayerGStatsGoalieRating04.Add("Hugo Alnefelt","Goal");
PlayerGStatsGoalieRating04.Add("Brian Elliott","Save, to C");
PlayerGStatsGoalieRating04.Add("Maxime Lagace","Save, to Any");
PlayerGStatsGoalieRating04.Add("Alexei Melnichuk","Goal");
PlayerGStatsGoalieRating04.Add("Andrei Vasilevskiy","Save, to RW");
PlayerGStatsGoalieRating04.Add("Michael Hutchinson","Save, to Any");
PlayerGStatsGoalieRating04.Add("Carter Hutton","Save, to LW");
PlayerGStatsGoalieRating04.Add("Erik Kallgren","Save, to LW");
PlayerGStatsGoalieRating04.Add("Matt Murray","Penalty");
PlayerGStatsGoalieRating04.Add("Ilya Samsonov","Save, to LD");
PlayerGStatsGoalieRating04.Add("Joseph Woll","Save, to LW");
PlayerGStatsGoalieRating04.Add("Thatcher Demko","OUT: Goal / IRB: Breakaway");
PlayerGStatsGoalieRating04.Add("Michael DiPietro","Save, to RW");
PlayerGStatsGoalieRating04.Add("Spencer Martin","Goal");
PlayerGStatsGoalieRating04.Add("Laurent Brossoit","Save, to LW");
PlayerGStatsGoalieRating04.Add("Robin Lehner","OUT: Penalty / IRB: Goal");
PlayerGStatsGoalieRating04.Add("Logan Thompson","Save, to LW");
PlayerGStatsGoalieRating04.Add("Zachary Fucale","Save, to RD");
PlayerGStatsGoalieRating04.Add("Darcy Kuemper","Goal");
PlayerGStatsGoalieRating04.Add("Charlie Lindgren","Save, to C");
PlayerGStatsGoalieRating04.Add("Connor Hellebuyck","Goal");
PlayerGStatsGoalieRating04.Add("David Rittich","Save, to RW");

FrPlayerGStatsGoalieRating04.Add("John GibsonANA","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating04.Add("JeanSebastian GiguereANA","Goal");
FrPlayerGStatsGoalieRating04.Add("Guy HebertANA","Penalty");
FrPlayerGStatsGoalieRating04.Add("Jonas HillerANA","Goal");
FrPlayerGStatsGoalieRating04.Add("Johan HedbergATL","Rebound");
FrPlayerGStatsGoalieRating04.Add("Kari LehtonenATL","Goal");
FrPlayerGStatsGoalieRating04.Add("Pasi NurminenATL","Rebound");
FrPlayerGStatsGoalieRating04.Add("Ondrej PavelecATL","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating04.Add("Gerry CheeversBOS","Rebound");
FrPlayerGStatsGoalieRating04.Add("Reggie LemelinBOS","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating04.Add("Andy MoogBOS","Rebound");
FrPlayerGStatsGoalieRating04.Add("Tuukka RaskBOS","Goal");
FrPlayerGStatsGoalieRating04.Add("Dominik HasekBUF","Save, to LW");
FrPlayerGStatsGoalieRating04.Add("Clint MalarchukBUF","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Ryan MillerBUF","Goal");
FrPlayerGStatsGoalieRating04.Add("Daren PuppaBUF","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Trevor KiddCAL","Rebound");
FrPlayerGStatsGoalieRating04.Add("Miikka KiprusoffCAL","Goal");
FrPlayerGStatsGoalieRating04.Add("Roman TurekCAL","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Mike VernonCAL","Rebound");
FrPlayerGStatsGoalieRating04.Add("Arturs IrbeCAR","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Petr MrazekCAR","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Cam WardCAR","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Kevin WeekesCAR","Goal");
FrPlayerGStatsGoalieRating04.Add("Sergei BobrovskyCBJ","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating04.Add("Marc DenisCBJ","Rebound");
FrPlayerGStatsGoalieRating04.Add("Pascal LeclaireCBJ","Penalty");
FrPlayerGStatsGoalieRating04.Add("Steve MasonCBJ","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Ed BelfourCHI","Save, to LD");
FrPlayerGStatsGoalieRating04.Add("Corey CrawfordCHI","Goal");
FrPlayerGStatsGoalieRating04.Add("Tony EspositoCHI","Rebound");
FrPlayerGStatsGoalieRating04.Add("Glenn HallCHI","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating04.Add("David AebischerCOL","Goal");
FrPlayerGStatsGoalieRating04.Add("Peter BudajCOL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating04.Add("Patrick RoyCOL","Goal");
FrPlayerGStatsGoalieRating04.Add("Semyon VarlamovCOL","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating04.Add("Ed BelfourDAL","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Kari LehtonenDAL","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating04.Add("Andy MoogDAL","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Marty TurcoDAL","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Tim CheveldaeDET","Penalty");
FrPlayerGStatsGoalieRating04.Add("Jimmy HowardDET","Goal");
FrPlayerGStatsGoalieRating04.Add("Chris OsgoodDET","Penalty");
FrPlayerGStatsGoalieRating04.Add("Terry SawchukDET","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Grant FuhrEDM","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Andy MoogEDM","Penalty");
FrPlayerGStatsGoalieRating04.Add("Bill RanfordEDM","Save, to LW");
FrPlayerGStatsGoalieRating04.Add("Tommy SaloEDM","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Sean BurkeFLA","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Roberto LuongoFLA","Goal");
FrPlayerGStatsGoalieRating04.Add("John VanbiesbrouckFLA","Goal");
FrPlayerGStatsGoalieRating04.Add("Tomas VokounFLA","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Sean BurkeHAR","Rebound");
FrPlayerGStatsGoalieRating04.Add("Mike LiutHAR","Rebound");
FrPlayerGStatsGoalieRating04.Add("Greg MillenHAR","Save, to LD");
FrPlayerGStatsGoalieRating04.Add("Peter SidorkiewiczHAR","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Stephane FisetLAK","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Kelly HrudeyLAK","Save, to LW");
FrPlayerGStatsGoalieRating04.Add("Jonathan QuickLAK","Goal");
FrPlayerGStatsGoalieRating04.Add("Rogatien VachonLAK","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating04.Add("Don BeaupreMNS","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Jon CaseyMNS","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Cesare ManiagoMNS","Save, to LD");
FrPlayerGStatsGoalieRating04.Add("Gilles MelocheMNS","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Niklas BackstromMNW","Goal");
FrPlayerGStatsGoalieRating04.Add("Devan DubnykMNW","Goal");
FrPlayerGStatsGoalieRating04.Add("Manny FernandezMNW","Goal");
FrPlayerGStatsGoalieRating04.Add("Dwayne RolosonMNW","Goal");
FrPlayerGStatsGoalieRating04.Add("Ken DrydenMON","Goal");
FrPlayerGStatsGoalieRating04.Add("Jacques PlanteMON","Goal");
FrPlayerGStatsGoalieRating04.Add("Carey PriceMON","Goal");
FrPlayerGStatsGoalieRating04.Add("Patrick RoyMON","Save, to LW");
FrPlayerGStatsGoalieRating04.Add("Mike DunhamNAS","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Chris MasonNAS","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Pekka RinneNAS","Goal");
FrPlayerGStatsGoalieRating04.Add("Tomas VokounNAS","Goal");
FrPlayerGStatsGoalieRating04.Add("Martin BrodeurNJD","Goal");
FrPlayerGStatsGoalieRating04.Add("Chico ReschNJD","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating04.Add("Cory SchneiderNJD","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating04.Add("Chris TerreriNJD","Rebound");
FrPlayerGStatsGoalieRating04.Add("Rick DiPietroNYI","Rebound");
FrPlayerGStatsGoalieRating04.Add("Kelly HrudeyNYI","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Chico ReschNYI","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Billy SmithNYI","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Eddie GiacominNYR","Rebound");
FrPlayerGStatsGoalieRating04.Add("Henrik LundqvistNYR","Goal");
FrPlayerGStatsGoalieRating04.Add("Mike RichterNYR","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating04.Add("Gump WorsleyNYR","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Craig AndersonOTT","Goal");
FrPlayerGStatsGoalieRating04.Add("Patrick LalimeOTT","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Damian RhodesOTT","Save, to LW");
FrPlayerGStatsGoalieRating04.Add("Ron TugnuttOTT","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Brian BoucherPHI","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Ron HextallPHI","Rebound");
FrPlayerGStatsGoalieRating04.Add("Pelle LindberghPHI","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Bernie ParentPHI","Goal");
FrPlayerGStatsGoalieRating04.Add("Ilya BryzgalovPHO","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating04.Add("Sean BurkePHO","Goal");
FrPlayerGStatsGoalieRating04.Add("Nikolai KhabibulinPHO","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Mike SmithPHO","Goal");
FrPlayerGStatsGoalieRating04.Add("Tom BarrassoPIT","Breakaway");
FrPlayerGStatsGoalieRating04.Add("MarcAndre FleuryPIT","Goal");
FrPlayerGStatsGoalieRating04.Add("Denis HerronPIT","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Ken WreggetPIT","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Dan BouchardQUE","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Stephane FisetQUE","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Mario GosselinQUE","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Ron TugnuttQUE","Save, to LW");
FrPlayerGStatsGoalieRating04.Add("Arturs IrbeSJS","Penalty");
FrPlayerGStatsGoalieRating04.Add("Martin JonesSJS","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Evgeni NabokovSJS","Goal");
FrPlayerGStatsGoalieRating04.Add("Antti NiemiSJS","Goal");
FrPlayerGStatsGoalieRating04.Add("Jake AllenSTL","Goal");
FrPlayerGStatsGoalieRating04.Add("Grant FuhrSTL","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Curtis JosephSTL","Rebound");
FrPlayerGStatsGoalieRating04.Add("Mike LiutSTL","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Ben BishopTBL","Goal");
FrPlayerGStatsGoalieRating04.Add("Nikolai KhabibulinTBL","Goal");
FrPlayerGStatsGoalieRating04.Add("Daren PuppaTBL","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Andrei VasilevskiyTBL","Goal");
FrPlayerGStatsGoalieRating04.Add("Johnny BowerTOR","Breakaway");
FrPlayerGStatsGoalieRating04.Add("Turk BrodaTOR","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Curtis JosephTOR","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Felix PotvinTOR","Rebound");
FrPlayerGStatsGoalieRating04.Add("Richard BrodeurVAN","Save, to RW");
FrPlayerGStatsGoalieRating04.Add("Dan CloutierVAN","Save, to LD");
FrPlayerGStatsGoalieRating04.Add("Roberto LuongoVAN","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating04.Add("Kirk McLeanVAN","Save, to C");
FrPlayerGStatsGoalieRating04.Add("Don BeaupreWAS","Rebound");
FrPlayerGStatsGoalieRating04.Add("Braden HoltbyWAS","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating04.Add("Al JensenWAS","Rebound");
FrPlayerGStatsGoalieRating04.Add("Olaf KolzigWAS","Save, to Any");
FrPlayerGStatsGoalieRating04.Add("Bob EssensaWPG","Save, to RD");
FrPlayerGStatsGoalieRating04.Add("Brian HaywardWPG","Goal");
FrPlayerGStatsGoalieRating04.Add("Connor HellebuyckWPG","Goal");
FrPlayerGStatsGoalieRating04.Add("Ondrej PavelecWPG","Save, to LW");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}