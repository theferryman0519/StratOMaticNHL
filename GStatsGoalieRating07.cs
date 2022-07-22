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

public class GStatsGoalieRating07 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating07 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating07 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating07.Add("Lukas Dostal","Save, to LW");
PlayerGStatsGoalieRating07.Add("John Gibson","Save, to RD");
PlayerGStatsGoalieRating07.Add("Thomas Hodges","Rebound");
PlayerGStatsGoalieRating07.Add("Anthony Stolarz","Save, to C");
PlayerGStatsGoalieRating07.Add("Josef Korenar","Save, to Any");
PlayerGStatsGoalieRating07.Add("Ivan Prosvetov","Goal");
PlayerGStatsGoalieRating07.Add("Harri Sateri","Save, to Any");
PlayerGStatsGoalieRating07.Add("Karel Vejmelka","Goal");
PlayerGStatsGoalieRating07.Add("Troy Grosenick","Save, to C");
PlayerGStatsGoalieRating07.Add("Jeremy Swayman","Save, to RW");
PlayerGStatsGoalieRating07.Add("Linus Ullmark","Save, to C");
PlayerGStatsGoalieRating07.Add("Craig Anderson","Save, to Any");
PlayerGStatsGoalieRating07.Add("Eric Comrie","Save, to RD");
PlayerGStatsGoalieRating07.Add("Michael Houser","Rebound");
PlayerGStatsGoalieRating07.Add("UkkoPekka Luukkonen","Save, to Any");
PlayerGStatsGoalieRating07.Add("Malcolm Subban","Save, to RW");
PlayerGStatsGoalieRating07.Add("Dustin Tokarski","Save, to C");
PlayerGStatsGoalieRating07.Add("Jacob Markstrom","Save, to RD");
PlayerGStatsGoalieRating07.Add("Daniel Vladar","Save, to C");
PlayerGStatsGoalieRating07.Add("Adam Werner","Save, to C");
PlayerGStatsGoalieRating07.Add("Frederik Andersen","Penalty");
PlayerGStatsGoalieRating07.Add("Pyotr Kochetkov","Save, to RW");
PlayerGStatsGoalieRating07.Add("Jack LaFontaine","Save, to LD");
PlayerGStatsGoalieRating07.Add("Alex Lyon","Save, to LW");
PlayerGStatsGoalieRating07.Add("Antti Raanta","Save, to LW");
PlayerGStatsGoalieRating07.Add("JeanFrancois Berube","Save, to LW");
PlayerGStatsGoalieRating07.Add("Joonas Korpisalo","OUT: Breakaway / IRB: Penalty");
PlayerGStatsGoalieRating07.Add("Elvis Merzlikins","OUT: Penalty / IRB: Breakaway");
PlayerGStatsGoalieRating07.Add("Daniil Tarasov","Save, to LD");
PlayerGStatsGoalieRating07.Add("Collin Delia","Save, to Any");
PlayerGStatsGoalieRating07.Add("Kevin Lankinen","Breakaway");
PlayerGStatsGoalieRating07.Add("Petr Mrazek","Save, to LW");
PlayerGStatsGoalieRating07.Add("Arvid Soderblom","Goal");
PlayerGStatsGoalieRating07.Add("Alex Stalock","Save, to LW");
PlayerGStatsGoalieRating07.Add("Justus Annunen","Goal");
PlayerGStatsGoalieRating07.Add("Pavel Francouz","Penalty");
PlayerGStatsGoalieRating07.Add("Alexandar Georgiev","Save, to RW");
PlayerGStatsGoalieRating07.Add("Hunter Miska","Save, to C");
PlayerGStatsGoalieRating07.Add("Landon Bow","Save, to RW");
PlayerGStatsGoalieRating07.Add("Braden Holtby","Breakaway");
PlayerGStatsGoalieRating07.Add("Anton Khudobin","Save, to LW");
PlayerGStatsGoalieRating07.Add("Jake Oettinger","Breakaway");
PlayerGStatsGoalieRating07.Add("Scott Wedgewood","Save, to RW");
PlayerGStatsGoalieRating07.Add("Kaden Fulcher","Save, to RW");
PlayerGStatsGoalieRating07.Add("Magnus Hellberg","Breakaway");
PlayerGStatsGoalieRating07.Add("Ville Husso","Save, to RD");
PlayerGStatsGoalieRating07.Add("Alex Nedeljkovic","Save, to RW");
PlayerGStatsGoalieRating07.Add("Jack Campbell","Save, to Any");
PlayerGStatsGoalieRating07.Add("Mikko Koskinen","Breakaway");
PlayerGStatsGoalieRating07.Add("Calvin Pickard","Save, to LD");
PlayerGStatsGoalieRating07.Add("Stuart Skinner","Save, to RD");
PlayerGStatsGoalieRating07.Add("Mike Smith","Save, to RW");
PlayerGStatsGoalieRating07.Add("Sergei Bobrovsky","Save, to LD");
PlayerGStatsGoalieRating07.Add("Christopher Gibson","Save, to RD");
PlayerGStatsGoalieRating07.Add("Jonas Johansson","Save, to LW");
PlayerGStatsGoalieRating07.Add("Spencer Knight","Save, to C");
PlayerGStatsGoalieRating07.Add("Pheonix Copley","Save, to LD");
PlayerGStatsGoalieRating07.Add("Cal Petersen","Save, to RW");
PlayerGStatsGoalieRating07.Add("Jonathan Quick","Breakaway");
PlayerGStatsGoalieRating07.Add("Garret Sparks","Goal");
PlayerGStatsGoalieRating07.Add("MarcAndre Fleury","Save, to LD");
PlayerGStatsGoalieRating07.Add("Filip Gustavsson","Save, to LD");
PlayerGStatsGoalieRating07.Add("Jake Allen","Save, to RW");
PlayerGStatsGoalieRating07.Add("Andrew Hammond","Save, to LD");
PlayerGStatsGoalieRating07.Add("Michael McNiven","Save, to RD");
PlayerGStatsGoalieRating07.Add("Samuel Montembeault","Save, to Any");
PlayerGStatsGoalieRating07.Add("Carey Price","Save, to RW");
PlayerGStatsGoalieRating07.Add("Cayden Primeau","Goal");
PlayerGStatsGoalieRating07.Add("Connor Ingram","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating07.Add("Juuse Saros","Save, to RD");
PlayerGStatsGoalieRating07.Add("Jonathan Bernier","Breakaway");
PlayerGStatsGoalieRating07.Add("Mackenzie Blackwood","Save, to C");
PlayerGStatsGoalieRating07.Add("Nico Daws","Save, to C");
PlayerGStatsGoalieRating07.Add("Akira Schmid","OUT: Goal / IRB: Rebound");
PlayerGStatsGoalieRating07.Add("Gilles Senn","Save, to Any");
PlayerGStatsGoalieRating07.Add("Vitek Vanecek","Save, to LW");
PlayerGStatsGoalieRating07.Add("Cory Schneider","Breakaway");
PlayerGStatsGoalieRating07.Add("Ilya Sorokin","Rebound");
PlayerGStatsGoalieRating07.Add("Semyon Varlamov","Save, to Any");
PlayerGStatsGoalieRating07.Add("Louis Domingue","Save, to RW");
PlayerGStatsGoalieRating07.Add("Jaroslav Halak","Save, to C");
PlayerGStatsGoalieRating07.Add("Adam Huska","Save, to RD");
PlayerGStatsGoalieRating07.Add("Keith Kinkaid","Goal");
PlayerGStatsGoalieRating07.Add("Igor Shesterkin","Save, to RW");
PlayerGStatsGoalieRating07.Add("Anton Forsberg","Save, to Any");
PlayerGStatsGoalieRating07.Add("Mads Sogaard","Save, to LW");
PlayerGStatsGoalieRating07.Add("Cam Talbot","Save, to RW");
PlayerGStatsGoalieRating07.Add("Carter Hart","Penalty");
PlayerGStatsGoalieRating07.Add("Felix Sandstrom","Rebound");
PlayerGStatsGoalieRating07.Add("Casey DeSmith","Save, to RD");
PlayerGStatsGoalieRating07.Add("Tristan Jarry","Save, to C");
PlayerGStatsGoalieRating07.Add("Antoine Bibeau","Rebound");
PlayerGStatsGoalieRating07.Add("Joey Daccord","Save, to RD");
PlayerGStatsGoalieRating07.Add("Chris Driedger","Rebound");
PlayerGStatsGoalieRating07.Add("Philipp Grubauer","Penalty");
PlayerGStatsGoalieRating07.Add("Martin Jones","Penalty");
PlayerGStatsGoalieRating07.Add("Aaron Dell","Save, to LW");
PlayerGStatsGoalieRating07.Add("Adin Hill","Penalty");
PlayerGStatsGoalieRating07.Add("Kaapo Kahkonen","Save, to RW");
PlayerGStatsGoalieRating07.Add("James Reimer","Penalty");
PlayerGStatsGoalieRating07.Add("Zachary Sawchenko","Save, to Any");
PlayerGStatsGoalieRating07.Add("Jordan Binnington","Save, to LW");
PlayerGStatsGoalieRating07.Add("Jon Gillies","Rebound");
PlayerGStatsGoalieRating07.Add("Thomas Greiss","Save, to LD");
PlayerGStatsGoalieRating07.Add("Joel Hofer","OUT: Rebound / IRB: Goal");
PlayerGStatsGoalieRating07.Add("Hugo Alnefelt","Save, to RD");
PlayerGStatsGoalieRating07.Add("Brian Elliott","Save, to LW");
PlayerGStatsGoalieRating07.Add("Maxime Lagace","Goal");
PlayerGStatsGoalieRating07.Add("Alexei Melnichuk","Rebound");
PlayerGStatsGoalieRating07.Add("Andrei Vasilevskiy","Save, to RD");
PlayerGStatsGoalieRating07.Add("Michael Hutchinson","Save, to LW");
PlayerGStatsGoalieRating07.Add("Carter Hutton","Breakaway");
PlayerGStatsGoalieRating07.Add("Erik Kallgren","Rebound");
PlayerGStatsGoalieRating07.Add("Matt Murray","Save, to Any");
PlayerGStatsGoalieRating07.Add("Ilya Samsonov","Save, to LD");
PlayerGStatsGoalieRating07.Add("Joseph Woll","Rebound");
PlayerGStatsGoalieRating07.Add("Thatcher Demko","Save, to RW");
PlayerGStatsGoalieRating07.Add("Michael DiPietro","Save, to LW");
PlayerGStatsGoalieRating07.Add("Spencer Martin","Save, to LD");
PlayerGStatsGoalieRating07.Add("Laurent Brossoit","Save, to LW");
PlayerGStatsGoalieRating07.Add("Robin Lehner","Save, to RW");
PlayerGStatsGoalieRating07.Add("Logan Thompson","Save, to Any");
PlayerGStatsGoalieRating07.Add("Zachary Fucale","Save, to LD");
PlayerGStatsGoalieRating07.Add("Darcy Kuemper","Save, to Any");
PlayerGStatsGoalieRating07.Add("Charlie Lindgren","Rebound");
PlayerGStatsGoalieRating07.Add("Connor Hellebuyck","Breakaway");
PlayerGStatsGoalieRating07.Add("David Rittich","Save, to Any");

FrPlayerGStatsGoalieRating07.Add("John GibsonANA","Save, to C");
FrPlayerGStatsGoalieRating07.Add("JeanSebastian GiguereANA","Penalty");
FrPlayerGStatsGoalieRating07.Add("Guy HebertANA","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Jonas HillerANA","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Johan HedbergATL","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Kari LehtonenATL","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Pasi NurminenATL","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Ondrej PavelecATL","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Gerry CheeversBOS","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Reggie LemelinBOS","Goal");
FrPlayerGStatsGoalieRating07.Add("Andy MoogBOS","Goal");
FrPlayerGStatsGoalieRating07.Add("Tuukka RaskBOS","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Dominik HasekBUF","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Clint MalarchukBUF","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Ryan MillerBUF","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Daren PuppaBUF","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating07.Add("Trevor KiddCAL","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Miikka KiprusoffCAL","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Roman TurekCAL","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Mike VernonCAL","Goal");
FrPlayerGStatsGoalieRating07.Add("Arturs IrbeCAR","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Petr MrazekCAR","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Cam WardCAR","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Kevin WeekesCAR","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Sergei BobrovskyCBJ","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Marc DenisCBJ","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Pascal LeclaireCBJ","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Steve MasonCBJ","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Ed BelfourCHI","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Corey CrawfordCHI","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Tony EspositoCHI","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Glenn HallCHI","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("David AebischerCOL","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Peter BudajCOL","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Patrick RoyCOL","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Semyon VarlamovCOL","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Ed BelfourDAL","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Kari LehtonenDAL","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Andy MoogDAL","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Marty TurcoDAL","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Tim CheveldaeDET","Goal");
FrPlayerGStatsGoalieRating07.Add("Jimmy HowardDET","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Chris OsgoodDET","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Terry SawchukDET","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Grant FuhrEDM","Goal");
FrPlayerGStatsGoalieRating07.Add("Andy MoogEDM","Goal");
FrPlayerGStatsGoalieRating07.Add("Bill RanfordEDM","Goal");
FrPlayerGStatsGoalieRating07.Add("Tommy SaloEDM","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Sean BurkeFLA","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Roberto LuongoFLA","Breakaway");
FrPlayerGStatsGoalieRating07.Add("John VanbiesbrouckFLA","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Tomas VokounFLA","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Sean BurkeHAR","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Mike LiutHAR","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Greg MillenHAR","Rebound");
FrPlayerGStatsGoalieRating07.Add("Peter SidorkiewiczHAR","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Stephane FisetLAK","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Kelly HrudeyLAK","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating07.Add("Jonathan QuickLAK","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Rogatien VachonLAK","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Don BeaupreMNS","Goal");
FrPlayerGStatsGoalieRating07.Add("Jon CaseyMNS","Goal");
FrPlayerGStatsGoalieRating07.Add("Cesare ManiagoMNS","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Gilles MelocheMNS","Goal");
FrPlayerGStatsGoalieRating07.Add("Niklas BackstromMNW","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Devan DubnykMNW","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Manny FernandezMNW","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Dwayne RolosonMNW","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Ken DrydenMON","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Jacques PlanteMON","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Carey PriceMON","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Patrick RoyMON","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Mike DunhamNAS","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Chris MasonNAS","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Pekka RinneNAS","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Tomas VokounNAS","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Martin BrodeurNJD","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Chico ReschNJD","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating07.Add("Cory SchneiderNJD","Penalty");
FrPlayerGStatsGoalieRating07.Add("Chris TerreriNJD","OUT: Breakaway / IRB: Goal");
FrPlayerGStatsGoalieRating07.Add("Rick DiPietroNYI","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Kelly HrudeyNYI","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Chico ReschNYI","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Billy SmithNYI","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Eddie GiacominNYR","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Henrik LundqvistNYR","Penalty");
FrPlayerGStatsGoalieRating07.Add("Mike RichterNYR","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Gump WorsleyNYR","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Craig AndersonOTT","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Patrick LalimeOTT","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Damian RhodesOTT","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Ron TugnuttOTT","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Brian BoucherPHI","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Ron HextallPHI","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("Pelle LindberghPHI","Goal");
FrPlayerGStatsGoalieRating07.Add("Bernie ParentPHI","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Ilya BryzgalovPHO","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Sean BurkePHO","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Nikolai KhabibulinPHO","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Mike SmithPHO","OUT: Penalty / IRB: Breakaway");
FrPlayerGStatsGoalieRating07.Add("Tom BarrassoPIT","Save, to LW");
FrPlayerGStatsGoalieRating07.Add("MarcAndre FleuryPIT","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Denis HerronPIT","OUT: Goal / IRB: Rebound");
FrPlayerGStatsGoalieRating07.Add("Ken WreggetPIT","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Dan BouchardQUE","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Stephane FisetQUE","Goal");
FrPlayerGStatsGoalieRating07.Add("Mario GosselinQUE","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Ron TugnuttQUE","Rebound");
FrPlayerGStatsGoalieRating07.Add("Arturs IrbeSJS","Goal");
FrPlayerGStatsGoalieRating07.Add("Martin JonesSJS","Penalty");
FrPlayerGStatsGoalieRating07.Add("Evgeni NabokovSJS","Penalty");
FrPlayerGStatsGoalieRating07.Add("Antti NiemiSJS","OUT: Breakaway / IRB: Penalty");
FrPlayerGStatsGoalieRating07.Add("Jake AllenSTL","Penalty");
FrPlayerGStatsGoalieRating07.Add("Grant FuhrSTL","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Curtis JosephSTL","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Mike LiutSTL","Goal");
FrPlayerGStatsGoalieRating07.Add("Ben BishopTBL","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Nikolai KhabibulinTBL","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Daren PuppaTBL","Save, to RW");
FrPlayerGStatsGoalieRating07.Add("Andrei VasilevskiyTBL","Save, to RD");
FrPlayerGStatsGoalieRating07.Add("Johnny BowerTOR","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Turk BrodaTOR","Penalty");
FrPlayerGStatsGoalieRating07.Add("Curtis JosephTOR","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Felix PotvinTOR","Save, to LD");
FrPlayerGStatsGoalieRating07.Add("Richard BrodeurVAN","OUT: Breakaway / IRB: Rebound");
FrPlayerGStatsGoalieRating07.Add("Dan CloutierVAN","Save, to C");
FrPlayerGStatsGoalieRating07.Add("Roberto LuongoVAN","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Kirk McLeanVAN","Goal");
FrPlayerGStatsGoalieRating07.Add("Don BeaupreWAS","Goal");
FrPlayerGStatsGoalieRating07.Add("Braden HoltbyWAS","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Al JensenWAS","Goal");
FrPlayerGStatsGoalieRating07.Add("Olaf KolzigWAS","Breakaway");
FrPlayerGStatsGoalieRating07.Add("Bob EssensaWPG","Save, to Any");
FrPlayerGStatsGoalieRating07.Add("Brian HaywardWPG","Rebound");
FrPlayerGStatsGoalieRating07.Add("Connor HellebuyckWPG","OUT: Breakaway / IRB: Penalty");
FrPlayerGStatsGoalieRating07.Add("Ondrej PavelecWPG","Penalty");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}