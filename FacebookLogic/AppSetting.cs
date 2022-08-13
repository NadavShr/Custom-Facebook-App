using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FacebookLogic
{
    public class AppSetting
    {
        public static string          AppId { get; } = "594110275627864";
        private const string          k_EmptyString = "";
        private const string          k_FullFilePath = "C:/Temp/FacebookAppFolder.txt";
        public const int              k_FacebookCollectionLimit = 15;
        public static string[]        RequestedPermission { get; } =
        {
            "email","public_profile", "user_age_range","user_birthday","user_events","user_friends",
            "user_gender", "user_hometown", "user_likes", "user_link",  "user_location", "user_photos", "user_posts",
        };

        public static void SaveAccessToken(string i_AceessToken)
        {
            using (StreamWriter writer = new StreamWriter(k_FullFilePath))
            {
                writer.WriteLine(i_AceessToken);
            }
        }

        public static string LoadAccessToken()
        {
            string accessToken = k_EmptyString;

            try
            {
                accessToken = File.ReadAllText(k_FullFilePath);
            }
            catch (IOException ioException) {};

            return accessToken;
        }

        public static bool CheckIfHasAcessToken()
        {
            return !string.IsNullOrEmpty(LoadAccessToken());
        }

        public static void DeleteAccessToken()
        {
            File.Delete(k_FullFilePath);
        }
    }
}
