using System.Text.Json;
using WebApplication1.Modal;

namespace WebApplication1.Services
{

    //due to change in enviroment setup we did this env CODE
    public class JsonFileBookServices
    {
        //    jsonfile to this program
        //address of file

        //khud file ka root generate kery

        //variable for HOME/ root dir/
        //gen file address
        // file handiling

        // by default it has get setter method

        //contructor JsonFileBookServices is var ko set kry gah
        public IWebHostEnvironment  WebHostEnvironment { get; set; }

        //actual hosting envirnment
        public JsonFileBookServices(IWebHostEnvironment WebHostEnvironment)
        {
            WebHostEnvironment = WebHostEnvironment;
        }


        public string fileAddress {
            get
            {
               return Path.Combine(WebHostEnvironment.WebRootPath,"data","books.json");
            }
        }

        //IEnumerable is list: contain Term and Description
        //id = 1 ; id is term and 1 desc
        // List =Array
        public IEnumerable<Book> getBookRecord()

        {
            //this will get file and store in fileStram
            // using mean if this file is opening then do this in using{ --- code--- }
            using(var fileStream = File.OpenText(fileAddress))
            {
                //string data in this
                //fileStream.ReadToEnd();
                // now we have to convert in address variable

                //automatic list ma bna dy gah or obj ma save kr dy gah???
                //>>>ya ab data ly rha json file sa and string ma store kr rha after this data ko seperate kr rha jis trha humny consol ma \t ki base py seprate kr rhy thy and bad ma in ko hum int, and string dataype ma rkh rhy thyy
                return JsonSerializer.Deserialize<Book[]>(fileStream.ReadToEnd());

            }

        }
        



    }
}
