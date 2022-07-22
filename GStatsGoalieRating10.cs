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

public class GStatsGoalieRating10 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsGoalieRating10 = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsGoalieRating10 = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsGoalieRating10.Add("Lukas Dostal","Save, to C");
PlayerGStatsGoalieRating10.Add("John Gibson","Goal");
PlayerGStatsGoalieRating10.Add("Thomas Hodges","Save, to RD");
PlayerGStatsGoalieRating10.Add("Anthony Stolarz","Save, to LW");
PlayerGStatsGoalieRating10.Add("Josef Korenar","Save, to C");
PlayerGStatsGoalieRating10.Add("Ivan Prosvetov","Breakaway");
PlayerGStatsGoalieRating10.Add("Harri Sateri","Penalty");
PlayerGStatsGoalieRating10.Add("Karel Vejmelka","Save, to LW");
PlayerGStatsGoalieRating10.Add("Troy Grosenick","Save, to Any");
PlayerGStatsGoalieRating10.Add("Jeremy Swayman","Goal");
PlayerGStatsGoalieRating10.Add("Linus Ullmark","Goal");
PlayerGStatsGoalieRating10.Add("Craig Anderson","Save, to RW");
PlayerGStatsGoalieRating10.Add("Eric Comrie","Save, to LW");
PlayerGStatsGoalieRating10.Add("Michael Houser","Goal");
PlayerGStatsGoalieRating10.Add("UkkoPekka Luukkonen","Save, to LD");
PlayerGStatsGoalieRating10.Add("Malcolm Subban","Save, to Any");
PlayerGStatsGoalieRating10.Add("Dustin Tokarski","Rebound");
PlayerGStatsGoalieRating10.Add("Jacob Markstrom","Goal");
PlayerGStatsGoalieRating10.Add("Daniel Vladar","Save, to RD");
PlayerGStatsGoalieRating10.Add("Adam Werner","Goal");
PlayerGStatsGoalieRating10.Add("Frederik Andersen","Goal");
PlayerGStatsGoalieRating10.Add("Pyotr Kochetkov","Goal");
PlayerGStatsGoalieRating10.Add("Jack LaFontaine","Save, to Any");
PlayerGStatsGoalieRating10.Add("Alex Lyon","Rebound");
PlayerGStatsGoalieRating10.Add("Antti Raanta","Goal");
PlayerGStatsGoalieRating10.Add("JeanFrancois Berube","Save, to RD");
PlayerGStatsGoalieRating10.Add("Joonas Korpisalo","Save, to C");
PlayerGStatsGoalieRating10.Add("Elvis Merzlikins","Goal");
PlayerGStatsGoalieRating10.Add("Daniil Tarasov","Save, to RW");
PlayerGStatsGoalieRating10.Add("Collin Delia","Save, to LW");
PlayerGStatsGoalieRating10.Add("Kevin Lankinen","Save, to LD");
PlayerGStatsGoalieRating10.Add("Petr Mrazek","Goal");
PlayerGStatsGoalieRating10.Add("Arvid Soderblom","Save, to RD");
PlayerGStatsGoalieRating10.Add("Alex Stalock","Goal");
PlayerGStatsGoalieRating10.Add("Justus Annunen","Save, to RD");
PlayerGStatsGoalieRating10.Add("Pavel Francouz","Save, to RW");
PlayerGStatsGoalieRating10.Add("Alexandar Georgiev","Goal");
PlayerGStatsGoalieRating10.Add("Hunter Miska","Rebound");
PlayerGStatsGoalieRating10.Add("Landon Bow","Save, to LW");
PlayerGStatsGoalieRating10.Add("Braden Holtby","Save, to RD");
PlayerGStatsGoalieRating10.Add("Anton Khudobin","Goal");
PlayerGStatsGoalieRating10.Add("Jake Oettinger","Goal");
PlayerGStatsGoalieRating10.Add("Scott Wedgewood","Save, to LD");
PlayerGStatsGoalieRating10.Add("Kaden Fulcher","Save, to LW");
PlayerGStatsGoalieRating10.Add("Magnus Hellberg","Save, to LW");
PlayerGStatsGoalieRating10.Add("Ville Husso","Save, to RD");
PlayerGStatsGoalieRating10.Add("Alex Nedeljkovic","Save, to RD");
PlayerGStatsGoalieRating10.Add("Jack Campbell","Save, to C");
PlayerGStatsGoalieRating10.Add("Mikko Koskinen","Goal");
PlayerGStatsGoalieRating10.Add("Calvin Pickard","Save, to RW");
PlayerGStatsGoalieRating10.Add("Stuart Skinner","Save, to Any");
PlayerGStatsGoalieRating10.Add("Mike Smith","Breakaway");
PlayerGStatsGoalieRating10.Add("Sergei Bobrovsky","Goal");
PlayerGStatsGoalieRating10.Add("Christopher Gibson","Save, to LD");
PlayerGStatsGoalieRating10.Add("Jonas Johansson","Save, to RW");
PlayerGStatsGoalieRating10.Add("Spencer Knight","Goal");
PlayerGStatsGoalieRating10.Add("Pheonix Copley","Save, to LD");
PlayerGStatsGoalieRating10.Add("Cal Petersen","Goal");
PlayerGStatsGoalieRating10.Add("Jonathan Quick","Save, to C");
PlayerGStatsGoalieRating10.Add("Garret Sparks","Rebound");
PlayerGStatsGoalieRating10.Add("MarcAndre Fleury","Goal");
PlayerGStatsGoalieRating10.Add("Filip Gustavsson","Save, to RW");
PlayerGStatsGoalieRating10.Add("Jake Allen","Goal");
PlayerGStatsGoalieRating10.Add("Andrew Hammond","Save, to LW");
PlayerGStatsGoalieRating10.Add("Michael McNiven","Save, to RW");
PlayerGStatsGoalieRating10.Add("Samuel Montembeault","Save, to Any");
PlayerGStatsGoalieRating10.Add("Carey Price","Goal");
PlayerGStatsGoalieRating10.Add("Cayden Primeau","Rebound");
PlayerGStatsGoalieRating10.Add("Connor Ingram","Save, to C");
PlayerGStatsGoalieRating10.Add("Juuse Saros","Goal");
PlayerGStatsGoalieRating10.Add("Jonathan Bernier","Save, to C");
PlayerGStatsGoalieRating10.Add("Mackenzie Blackwood","Goal");
PlayerGStatsGoalieRating10.Add("Nico Daws","Save, to RD");
PlayerGStatsGoalieRating10.Add("Akira Schmid","Save, to Any");
PlayerGStatsGoalieRating10.Add("Gilles Senn","Save, to LW");
PlayerGStatsGoalieRating10.Add("Vitek Vanecek","Goal");
PlayerGStatsGoalieRating10.Add("Cory Schneider","Save, to Any");
PlayerGStatsGoalieRating10.Add("Ilya Sorokin","Save, to RD");
PlayerGStatsGoalieRating10.Add("Semyon Varlamov","Goal");
PlayerGStatsGoalieRating10.Add("Louis Domingue","Save, to C");
PlayerGStatsGoalieRating10.Add("Jaroslav Halak","Save, to LD");
PlayerGStatsGoalieRating10.Add("Adam Huska","Save, to Any");
PlayerGStatsGoalieRating10.Add("Keith Kinkaid","Rebound");
PlayerGStatsGoalieRating10.Add("Igor Shesterkin","Goal");
PlayerGStatsGoalieRating10.Add("Anton Forsberg","Rebound");
PlayerGStatsGoalieRating10.Add("Mads Sogaard","Save, to RD");
PlayerGStatsGoalieRating10.Add("Cam Talbot","Goal");
PlayerGStatsGoalieRating10.Add("Carter Hart","Goal");
PlayerGStatsGoalieRating10.Add("Felix Sandstrom","Save, to RD");
PlayerGStatsGoalieRating10.Add("Casey DeSmith","Save, to Any");
PlayerGStatsGoalieRating10.Add("Tristan Jarry","Goal");
PlayerGStatsGoalieRating10.Add("Antoine Bibeau","Save, to RD");
PlayerGStatsGoalieRating10.Add("Joey Daccord","Goal");
PlayerGStatsGoalieRating10.Add("Chris Driedger","Save, to RD");
PlayerGStatsGoalieRating10.Add("Philipp Grubauer","Goal");
PlayerGStatsGoalieRating10.Add("Martin Jones","Save, to RW");
PlayerGStatsGoalieRating10.Add("Aaron Dell","Save, to C");
PlayerGStatsGoalieRating10.Add("Adin Hill","Goal");
PlayerGStatsGoalieRating10.Add("Kaapo Kahkonen","Save, to LW");
PlayerGStatsGoalieRating10.Add("James Reimer","Save, to RW");
PlayerGStatsGoalieRating10.Add("Zachary Sawchenko","Goal");
PlayerGStatsGoalieRating10.Add("Jordan Binnington","Goal");
PlayerGStatsGoalieRating10.Add("Jon Gillies","Save, to LW");
PlayerGStatsGoalieRating10.Add("Thomas Greiss","Goal");
PlayerGStatsGoalieRating10.Add("Joel Hofer","Save, to LW");
PlayerGStatsGoalieRating10.Add("Hugo Alnefelt","Goal");
PlayerGStatsGoalieRating10.Add("Brian Elliott","Save, to C");
PlayerGStatsGoalieRating10.Add("Maxime Lagace","Save, to RW");
PlayerGStatsGoalieRating10.Add("Alexei Melnichuk","Save, to C");
PlayerGStatsGoalieRating10.Add("Andrei Vasilevskiy","Save, to LD");
PlayerGStatsGoalieRating10.Add("Michael Hutchinson","Save, to C");
PlayerGStatsGoalieRating10.Add("Carter Hutton","Save, to Any");
PlayerGStatsGoalieRating10.Add("Erik Kallgren","Save, to RD");
PlayerGStatsGoalieRating10.Add("Matt Murray","Save, to RW");
PlayerGStatsGoalieRating10.Add("Ilya Samsonov","Goal");
PlayerGStatsGoalieRating10.Add("Joseph Woll","Save, to RW");
PlayerGStatsGoalieRating10.Add("Thatcher Demko","Goal");
PlayerGStatsGoalieRating10.Add("Michael DiPietro","Goal");
PlayerGStatsGoalieRating10.Add("Spencer Martin","Goal");
PlayerGStatsGoalieRating10.Add("Laurent Brossoit","Goal");
PlayerGStatsGoalieRating10.Add("Robin Lehner","Save, to RD");
PlayerGStatsGoalieRating10.Add("Logan Thompson","Goal");
PlayerGStatsGoalieRating10.Add("Zachary Fucale","Save, to Any");
PlayerGStatsGoalieRating10.Add("Darcy Kuemper","Save, to RW");
PlayerGStatsGoalieRating10.Add("Charlie Lindgren","Save, to LD");
PlayerGStatsGoalieRating10.Add("Connor Hellebuyck","Save, to LD");
PlayerGStatsGoalieRating10.Add("David Rittich","Save, to C");

FrPlayerGStatsGoalieRating10.Add("John GibsonANA","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating10.Add("JeanSebastian GiguereANA","Goal");
FrPlayerGStatsGoalieRating10.Add("Guy HebertANA","Goal");
FrPlayerGStatsGoalieRating10.Add("Jonas HillerANA","Goal");
FrPlayerGStatsGoalieRating10.Add("Johan HedbergATL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Kari LehtonenATL","Goal");
FrPlayerGStatsGoalieRating10.Add("Pasi NurminenATL","Penalty");
FrPlayerGStatsGoalieRating10.Add("Ondrej PavelecATL","OUT: Rebound / IRB: Goal");
FrPlayerGStatsGoalieRating10.Add("Gerry CheeversBOS","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Reggie LemelinBOS","Penalty");
FrPlayerGStatsGoalieRating10.Add("Andy MoogBOS","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Tuukka RaskBOS","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Dominik HasekBUF","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Clint MalarchukBUF","Penalty");
FrPlayerGStatsGoalieRating10.Add("Ryan MillerBUF","Goal");
FrPlayerGStatsGoalieRating10.Add("Daren PuppaBUF","Penalty");
FrPlayerGStatsGoalieRating10.Add("Trevor KiddCAL","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Miikka KiprusoffCAL","Goal");
FrPlayerGStatsGoalieRating10.Add("Roman TurekCAL","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Mike VernonCAL","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Arturs IrbeCAR","Penalty");
FrPlayerGStatsGoalieRating10.Add("Petr MrazekCAR","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Cam WardCAR","Goal");
FrPlayerGStatsGoalieRating10.Add("Kevin WeekesCAR","Goal");
FrPlayerGStatsGoalieRating10.Add("Sergei BobrovskyCBJ","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Marc DenisCBJ","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Pascal LeclaireCBJ","Goal");
FrPlayerGStatsGoalieRating10.Add("Steve MasonCBJ","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Ed BelfourCHI","Penalty");
FrPlayerGStatsGoalieRating10.Add("Corey CrawfordCHI","Save, to LD");
FrPlayerGStatsGoalieRating10.Add("Tony EspositoCHI","Rebound");
FrPlayerGStatsGoalieRating10.Add("Glenn HallCHI","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating10.Add("David AebischerCOL","Goal");
FrPlayerGStatsGoalieRating10.Add("Peter BudajCOL","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Patrick RoyCOL","Penalty");
FrPlayerGStatsGoalieRating10.Add("Semyon VarlamovCOL","Goal");
FrPlayerGStatsGoalieRating10.Add("Ed BelfourDAL","Goal");
FrPlayerGStatsGoalieRating10.Add("Kari LehtonenDAL","OUT: Goal / IRB: Breakaway");
FrPlayerGStatsGoalieRating10.Add("Andy MoogDAL","Penalty");
FrPlayerGStatsGoalieRating10.Add("Marty TurcoDAL","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Tim CheveldaeDET","Rebound");
FrPlayerGStatsGoalieRating10.Add("Jimmy HowardDET","Goal");
FrPlayerGStatsGoalieRating10.Add("Chris OsgoodDET","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Terry SawchukDET","Save, to C");
FrPlayerGStatsGoalieRating10.Add("Grant FuhrEDM","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Andy MoogEDM","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Bill RanfordEDM","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Tommy SaloEDM","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Sean BurkeFLA","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Roberto LuongoFLA","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("John VanbiesbrouckFLA","OUT: Goal / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Tomas VokounFLA","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Sean BurkeHAR","Penalty");
FrPlayerGStatsGoalieRating10.Add("Mike LiutHAR","Rebound");
FrPlayerGStatsGoalieRating10.Add("Greg MillenHAR","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Peter SidorkiewiczHAR","OUT: Rebound / IRB: Breakaway");
FrPlayerGStatsGoalieRating10.Add("Stephane FisetLAK","Save, to C");
FrPlayerGStatsGoalieRating10.Add("Kelly HrudeyLAK","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Jonathan QuickLAK","Goal");
FrPlayerGStatsGoalieRating10.Add("Rogatien VachonLAK","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Don BeaupreMNS","Penalty");
FrPlayerGStatsGoalieRating10.Add("Jon CaseyMNS","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Cesare ManiagoMNS","Rebound");
FrPlayerGStatsGoalieRating10.Add("Gilles MelocheMNS","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Niklas BackstromMNW","Goal");
FrPlayerGStatsGoalieRating10.Add("Devan DubnykMNW","Penalty");
FrPlayerGStatsGoalieRating10.Add("Manny FernandezMNW","Goal");
FrPlayerGStatsGoalieRating10.Add("Dwayne RolosonMNW","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Ken DrydenMON","Breakaway");
FrPlayerGStatsGoalieRating10.Add("Jacques PlanteMON","Save, to C");
FrPlayerGStatsGoalieRating10.Add("Carey PriceMON","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Patrick RoyMON","Breakaway");
FrPlayerGStatsGoalieRating10.Add("Mike DunhamNAS","Goal");
FrPlayerGStatsGoalieRating10.Add("Chris MasonNAS","Goal");
FrPlayerGStatsGoalieRating10.Add("Pekka RinneNAS","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Tomas VokounNAS","OUT: Penalty / IRB: Goal");
FrPlayerGStatsGoalieRating10.Add("Martin BrodeurNJD","Goal");
FrPlayerGStatsGoalieRating10.Add("Chico ReschNJD","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Cory SchneiderNJD","Goal");
FrPlayerGStatsGoalieRating10.Add("Chris TerreriNJD","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Rick DiPietroNYI","Penalty");
FrPlayerGStatsGoalieRating10.Add("Kelly HrudeyNYI","Penalty");
FrPlayerGStatsGoalieRating10.Add("Chico ReschNYI","Goal");
FrPlayerGStatsGoalieRating10.Add("Billy SmithNYI","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Eddie GiacominNYR","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Henrik LundqvistNYR","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Mike RichterNYR","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Gump WorsleyNYR","OUT: Rebound / IRB: Goal");
FrPlayerGStatsGoalieRating10.Add("Craig AndersonOTT","Goal");
FrPlayerGStatsGoalieRating10.Add("Patrick LalimeOTT","Goal");
FrPlayerGStatsGoalieRating10.Add("Damian RhodesOTT","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Ron TugnuttOTT","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Brian BoucherPHI","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Ron HextallPHI","Penalty");
FrPlayerGStatsGoalieRating10.Add("Pelle LindberghPHI","Rebound");
FrPlayerGStatsGoalieRating10.Add("Bernie ParentPHI","Penalty");
FrPlayerGStatsGoalieRating10.Add("Ilya BryzgalovPHO","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Sean BurkePHO","Penalty");
FrPlayerGStatsGoalieRating10.Add("Nikolai KhabibulinPHO","Goal");
FrPlayerGStatsGoalieRating10.Add("Mike SmithPHO","Goal");
FrPlayerGStatsGoalieRating10.Add("Tom BarrassoPIT","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("MarcAndre FleuryPIT","Goal");
FrPlayerGStatsGoalieRating10.Add("Denis HerronPIT","Penalty");
FrPlayerGStatsGoalieRating10.Add("Ken WreggetPIT","OUT: Penalty / IRB: Rebound");
FrPlayerGStatsGoalieRating10.Add("Dan BouchardQUE","Penalty");
FrPlayerGStatsGoalieRating10.Add("Stephane FisetQUE","Rebound");
FrPlayerGStatsGoalieRating10.Add("Mario GosselinQUE","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Ron TugnuttQUE","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Arturs IrbeSJS","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Martin JonesSJS","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Evgeni NabokovSJS","Goal");
FrPlayerGStatsGoalieRating10.Add("Antti NiemiSJS","Goal");
FrPlayerGStatsGoalieRating10.Add("Jake AllenSTL","Goal");
FrPlayerGStatsGoalieRating10.Add("Grant FuhrSTL","Save, to LD");
FrPlayerGStatsGoalieRating10.Add("Curtis JosephSTL","Goal");
FrPlayerGStatsGoalieRating10.Add("Mike LiutSTL","Save, to RW");
FrPlayerGStatsGoalieRating10.Add("Ben BishopTBL","Save, to Any");
FrPlayerGStatsGoalieRating10.Add("Nikolai KhabibulinTBL","Goal");
FrPlayerGStatsGoalieRating10.Add("Daren PuppaTBL","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Andrei VasilevskiyTBL","Save, to LW");
FrPlayerGStatsGoalieRating10.Add("Johnny BowerTOR","Save, to C");
FrPlayerGStatsGoalieRating10.Add("Turk BrodaTOR","Save, to LD");
FrPlayerGStatsGoalieRating10.Add("Curtis JosephTOR","Goal");
FrPlayerGStatsGoalieRating10.Add("Felix PotvinTOR","Goal");
FrPlayerGStatsGoalieRating10.Add("Richard BrodeurVAN","Save, to LD");
FrPlayerGStatsGoalieRating10.Add("Dan CloutierVAN","Penalty");
FrPlayerGStatsGoalieRating10.Add("Roberto LuongoVAN","Save, to C");
FrPlayerGStatsGoalieRating10.Add("Kirk McLeanVAN","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Don BeaupreWAS","Penalty");
FrPlayerGStatsGoalieRating10.Add("Braden HoltbyWAS","Goal");
FrPlayerGStatsGoalieRating10.Add("Al JensenWAS","OUT: Rebound / IRB: Penalty");
FrPlayerGStatsGoalieRating10.Add("Olaf KolzigWAS","Penalty");
FrPlayerGStatsGoalieRating10.Add("Bob EssensaWPG","Rebound");
FrPlayerGStatsGoalieRating10.Add("Brian HaywardWPG","Save, to RD");
FrPlayerGStatsGoalieRating10.Add("Connor HellebuyckWPG","Goal");
FrPlayerGStatsGoalieRating10.Add("Ondrej PavelecWPG","Save, to Any");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}