namespace RottenTomatoes
{
    public class MovieData
    {
        public string rotten_tomatoes_link             {get;set;}  
        public string movie_title                      {get;set;}  
        public string movie_info                       {get;set;}  
        public string critics_consensus                {get;set;}  
        public string content_rating                   {get;set;}  
        public string genres                           {get;set;}  
        public string directors                        {get;set;}  
        public string authors                          {get;set;}  
        public string actors                           {get;set;}  
        public string original_release_date            {get;set;}  
        public string streaming_release_date           {get;set;}  
        public string runtime                          {get;set;}  
        public string production_company               {get;set;}  
        public string tomatometer_status               {get;set;}  
        public string tomatometer_rating               {get;set;}  
        public string tomatometer_count                {get;set;}  
        public string audience_status                  {get;set;}  
        public string audience_rating                  {get;set;}  
        public string audience_count                   {get;set;}  
        public string tomatometer_top_critics_count    {get;set;}  
        public string tomatometer_fresh_critics_count  {get;set;}
        public string tomatometer_rotten_critics_count {get;set;}

        public MovieData()
        {
            rotten_tomatoes_link = string.Empty;
            movie_title = string.Empty;
            movie_info = string.Empty;
            critics_consensus = string.Empty;
            content_rating = string.Empty;
            genres = string.Empty;
            directors = string.Empty;
            authors = string.Empty;
            actors = string.Empty;
            original_release_date = string.Empty;
            streaming_release_date = string.Empty;
            runtime = string.Empty;
            production_company = string.Empty;
            tomatometer_status = string.Empty;
            tomatometer_rating = string.Empty;
            tomatometer_count = string.Empty;
            audience_status = string.Empty;
            audience_rating = string.Empty;
            audience_count = string.Empty;
            tomatometer_top_critics_count = string.Empty;
            tomatometer_fresh_critics_count = string.Empty;
            tomatometer_rotten_critics_count = string.Empty;
        }
        public MovieData(string line)
        {
            var pieces = line.Split(',');

            rotten_tomatoes_link             = pieces[0];
            movie_title                      = pieces[1];
            movie_info                       = pieces[2];
            critics_consensus                = pieces[3];
            content_rating                   = pieces[4];
            genres                           = pieces[5];
            directors                        = pieces[6];
            authors                          = pieces[7];
            actors                           = pieces[8];
            original_release_date            = pieces[9];
            streaming_release_date           = pieces[10];
            runtime                          = pieces[11];
            production_company               = pieces[12];
            tomatometer_status               = pieces[13];
            tomatometer_rating               = pieces[14];
            tomatometer_count                = pieces[15];
            audience_status                  = pieces[16];
            audience_rating                  = pieces[17];
            audience_count                   = pieces[18];
            tomatometer_top_critics_count    = pieces[19];
            tomatometer_fresh_critics_count  = pieces[20];
            tomatometer_rotten_critics_count = pieces[21];
        }
    }
}