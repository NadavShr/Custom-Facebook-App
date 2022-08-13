using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookLogic
{
    public class BasicUserDetailsDTO
    {
        public String   ProfilePictureUrl { get; }
        public String   FullName { get; }
        public String   BirthDay { get; }
        public String   Location { get; }

        public BasicUserDetailsDTO(String i_ProfilePictureUrl, String i_FullName, String i_BirthDay, String i_Location)
        {
            this.ProfilePictureUrl = i_ProfilePictureUrl;
            this.FullName = i_FullName;
            this.BirthDay = i_BirthDay;
            this.Location = i_Location;
        }
    }
}
