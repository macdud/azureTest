using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAssistant.Models
{
    public class EventViewModel
    {
        public Pagination pagination { get; set; }
        public List<Event> events { get; set; }
        public Location location { get; set; }
    }

    public class Pagination
    {
        public int object_count { get; set; }
        public int page_number { get; set; }
        public int page_size { get; set; }
        public int page_count { get; set; }
    }

    public class Name
    {
        public string text { get; set; }
        public string html { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public string html { get; set; }
    }

    public class Start
    {
        public string timezone { get; set; }
        public string local { get; set; }
        public string utc { get; set; }
    }

    public class End
    {
        public string timezone { get; set; }
        public string local { get; set; }
        public string utc { get; set; }
    }

    public class Logo
    {
        public string id { get; set; }
        public string url { get; set; }
        public string aspect_ratio { get; set; }
        public string edge_color { get; set; }
        public bool edge_color_set { get; set; }
    }

    public class Event
    {
        public Name name { get; set; }
        public Description description { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string vanity_url { get; set; }
        public Start start { get; set; }
        public End end { get; set; }
        public string created { get; set; }
        public string changed { get; set; }
        public int capacity { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public bool listed { get; set; }
        public bool shareable { get; set; }
        public bool online_event { get; set; }
        public int tx_time_limit { get; set; }
        public bool hide_start_date { get; set; }
        public bool hide_end_date { get; set; }
        public string locale { get; set; }
        public bool is_locked { get; set; }
        public string privacy_setting { get; set; }
        public bool is_series { get; set; }
        public bool is_series_parent { get; set; }
        public bool is_reserved_seating { get; set; }
        public string logo_id { get; set; }
        public string organizer_id { get; set; }
        public string venue_id { get; set; }
        public string category_id { get; set; }
        public string subcategory_id { get; set; }
        public string format_id { get; set; }
        public string resource_uri { get; set; }
        public Logo logo { get; set; }
        public string series_id { get; set; }
    }

    public class Location
    {
        public string latitude { get; set; }
        public string within { get; set; }
        public string longitude { get; set; }
        public string address { get; set; }
    }


}