using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpssLib.SpssDataset;
using SpssLib.DataReader;
using System.IO;

namespace PhilCerealParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int SurveyID = 600548;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2017-07-31";
            //string year = getYear(SurveyPeriod); 
            string country = "philippines";//survey country
            DB_insertion_philcereals iobj = new DB_insertion_philcereals();
            string questions = "Respondent_ID,WEIGHT_BAN123,BAREA,S3a,Q60,Ban_age,S6,Q62,Q61,Q10_SUBNET,WAVE,Q11_01,Q11_02,Q11_03,Q11_04,Q11_05,Q11_06,Q11_09,Q11_10,Q11_11,Q11_19,Q11_20,Q11_31,Q11_32,Q11_45,Q11_54,Q11_55,Q11_78,Q11_81,Q11_82,Q11_136,Q13_01,Q13_02,Q13_03,Q13_04,Q13_05,Q13_06,Q13_09,Q13_10,Q13_11,Q13_19,Q13_20,Q13_31,Q13_32,Q13_45,Q13_54,Q13_55,Q13_78,Q13_81,Q13_82,Q13_136,Q12TOM_SUBNET,Q12_01,Q12_02,Q12_03,Q12_04,Q12_05,Q12_06,Q12_09,Q12_10,Q12_11,Q12_19,Q12_20,Q12_31,Q12_32,Q12_45,Q12_54,Q12_55,Q12_78,Q12_81,Q12_82,Q12_136,Q12Q14_01,Q12Q14_02,Q12Q14_03,Q12Q14_04,Q12Q14_05,Q12Q14_06,Q12Q14_09,Q12Q14_10,Q12Q14_11,Q12Q14_19,Q12Q14_20,Q12Q14_31,Q12Q14_32,Q12Q14_45,Q12Q14_54,Q12Q14_55,Q12Q14_78,Q12Q14_81,Q12Q14_82,Q12Q14_136,Q18_01,Q18_02,Q18_03,Q18_04,Q18_05,Q18_06,Q18_09,Q18_10,Q18_11,Q18_19,Q18_20,Q18_31,Q18_32,Q18_45,Q18_54,Q18_55,Q18_78,Q18_81,Q18_82,Q18_136,Q15Q16_01,Q15Q16_02,Q15Q16_03,Q15Q16_04,Q15Q16_05,Q15Q16_06,Q15Q16_09,Q15Q16_10,Q15Q16_11,Q15Q16_19,Q15Q16_20,Q15Q16_31,Q15Q16_32,Q15Q16_45,Q15Q16_54,Q15Q16_55,Q15Q16_78,Q15Q16_81,Q15Q16_82,Q15Q16_136,Q17_1_01,Q17_1_02,Q17_1_03,Q17_1_04,Q17_1_05,Q17_1_06,Q17_1_21,Q17_1_22,Q17_1_23,Q17_1_28,Q17_1_34,Q17_1_41,Q17_1_42,Q17_1_44,Q17_1_54,Q17_1_55,Q17_1_78,Q17_2_01,Q17_2_02,Q17_2_03,Q17_2_04,Q17_2_05,Q17_2_06,Q17_2_21,Q17_2_22,Q17_2_23,Q17_2_28,Q17_2_34,Q17_2_41,Q17_2_42,Q17_2_44,Q17_2_54,Q17_2_55,Q17_2_78,Q17_3_01,Q17_3_02,Q17_3_03,Q17_3_04,Q17_3_05,Q17_3_06,Q17_3_21,Q17_3_22,Q17_3_23,Q17_3_28,Q17_3_34,Q17_3_41,Q17_3_42,Q17_3_44,Q17_3_54,Q17_3_55,Q17_3_78,Q17_4_01,Q17_4_02,Q17_4_03,Q17_4_04,Q17_4_05,Q17_4_06,Q17_4_21,Q17_4_22,Q17_4_23,Q17_4_28,Q17_4_34,Q17_4_41,Q17_4_42,Q17_4_44,Q17_4_54,Q17_4_55,Q17_4_78,Q17_5_01,Q17_5_02,Q17_5_03,Q17_5_04,Q17_5_05,Q17_5_06,Q17_5_21,Q17_5_22,Q17_5_23,Q17_5_28,Q17_5_34,Q17_5_41,Q17_5_42,Q17_5_44,Q17_5_54,Q17_5_55,Q17_5_78,Q19_SUBNET,Q20_SUBNET,Q21_SUBNET,Q22,Q23_SUBNET,Q10_NET,Q11_79,Q11_80,Q11_82,Q11_85,Q11_88,Q13_79,Q13_80,Q13_82,Q13_85,Q13_88,Q12TOM_NET,Q12_79,Q12_80,Q12_82,Q12_85,Q12_88,Q12Q14_79,Q12Q14_80,Q12Q14_82,Q12Q14_85,Q12Q14_88,Q15Q16_79,Q15Q16_80,Q15Q16_82,Q15Q16_85,Q15Q16_88,Q18_79,Q18_80,Q18_82,Q18_85,Q18_88,Q19_NET,Q21_NET,Q20_NET,Q23_NET,Q52_5001_01,Q52_5001_02,Q52_5001_03,Q52_5001_04,Q52_5001_05,Q52_5001_06,Q52_5001_07,Q52_5001_08,Q52_5001_09,Q52_5001_10,Q52_5001_11,Q52_5001_12,Q52_6001_01,Q52_6001_02,Q52_6001_03,Q52_6001_04,Q52_6001_05,Q52_6001_06,Q52_6001_07,Q52_6001_08,Q52_6001_09,Q52_6001_10,Q52_6001_11,Q52_6001_12,Q17_1_79,Q17_1_80,Q17_1_82,Q17_1_85,Q17_1_88,Q17_2_79,Q17_2_80,Q17_2_82,Q17_2_85,Q17_2_88,Q17_3_79,Q17_3_80,Q17_3_82,Q17_3_85,Q17_3_88,Q17_4_79,Q17_4_80,Q17_4_82,Q17_4_85,Q17_4_88,Q17_5_79,Q17_5_80,Q17_5_82,Q17_5_85,Q17_5_88,Q32_5001_03,Q32_5001_04,Q32_5001_06,Q32_5001_07,Q32_5001_08,Q32_5001_14,Q32_5001_20,Q32_5001_21,Q32_6001_03,Q32_6001_04,Q32_6001_06,Q32_6001_07,Q32_6001_08,Q32_6001_14,Q32_6001_20,Q32_6001_21,Q32_7001_03,Q32_7001_04,Q32_7001_06,Q32_7001_07,Q32_7001_08,Q32_7001_14,Q32_7001_20,Q32_7001_21,Q32_81_03,Q32_81_04,Q32_81_06,Q32_81_07,Q32_81_08,Q32_81_14,Q32_81_20,Q32_81_21,Q32_136_03,Q32_136_04,Q32_136_06,Q32_136_07,Q32_136_08,Q32_136_14,Q32_136_20,Q32_136_21,S2,WAVE";// dashboard variable value          
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\Mysql_to_Xl\Phil-Cereal\PH-PLJUL-2017.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                                //iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, country, BASE_VARIABLE_NAME, AttendedOn);
                            }
                        }

                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string userID = null;
                    string u_id = null;  
                    string variable_name;
                    decimal Weight = 0;
                    string Country = "-- Not Available --";
                    string Period = "-- Not Available --";
                    string Location = "-- Not Available --";
                    string Gender = "-- Not Available --";
                    string MaritalStatus = "-- Not Available --";
                    string AgeGroup = "-- Not Available --";
                    string Ses = "-- Not Available --";
                    string Occupation = "-- Not Available --";
                    string Education = "-- Not Available --";
                    string BrTom = "-- Not Available --";
                    string BrSpontEnergen_Vanilla = "-- Not Available --";
                    string BrSpontEnergen_Choco = "-- Not Available --";
                    string BrSpontEnergen_Sweet_Corn = "-- Not Available --";
                    string BrSpontEnergen_Ginger = "-- Not Available --";
                    string BrSpontEnergen_unspec = "-- Not Available --";
                    string BrSpontEnergen_Go_Fruit = "-- Not Available --";
                    string BrSpontNBear_Busog_Lusog_Orig = "-- Not Available --";
                    string BrSpontNBear_Brand_Busog_Lusog_Choco = "-- Not Available --";
                    string BrSpontNBear_Brand_Busog_Lusog_unspec = "-- Not Available --";
                    string BrSpontNestle_Koko_Krunch = "-- Not Available --";
                    string BrSpontNestle_Koko_Krunch_AllInOne = "-- Not Available --";
                    string BrSpontQuaker_Instant_Oatmeal = "-- Not Available --";
                    string BrSpontQuaker_Quick_Cook = "-- Not Available --";
                    string BrSpontQuaker_unspec = "-- Not Available --";
                    string BrSpontEC_Choco_Flakes = "-- Not Available --";
                    string BrSpontEC_Milky_Flakes = "-- Not Available --";
                    string BrSpontMilo = "-- Not Available --";
                    string BrAidEnergen_Vanilla = "-- Not Available --";
                    string BrAidEnergen_Choco = "-- Not Available --";
                    string BrAidEnergen_Sweet_Corn = "-- Not Available --";
                    string BrAidEnergen_Ginger = "-- Not Available --";
                    string BrAidEnergen_unspec = "-- Not Available --";
                    string BrAidEnergen_Go_Fruit = "-- Not Available --";
                    string BrAidNBear_Busog_Lusog_Orig = "-- Not Available --";
                    string BrAidNBear_Brand_Busog_Lusog_Choco = "-- Not Available --";
                    string BrAidNBear_Brand_Busog_Lusog_unspec = "-- Not Available --";
                    string BrAidNestle_Koko_Krunch = "-- Not Available --";
                    string BrAidNestle_Koko_Krunch_AllInOne = "-- Not Available --";
                    string BrAidQuaker_Instant_Oatmeal = "-- Not Available --";
                    string BrAidQuaker_Quick_Cook = "-- Not Available --";
                    string BrAidQuaker_unspec = "-- Not Available --";
                    string BrAidEC_Choco_Flakes = "-- Not Available --";
                    string BrAidEC_Milky_Flakes = "-- Not Available --";
                    string BrAidMilo = "-- Not Available --";
                    string AdTom = "-- Not Available --";
                    string AdSpontEnergen_Vanilla = "-- Not Available --";
                    string AdSpontEnergen_Choco = "-- Not Available --";
                    string AdSpontEnergen_Sweet_Corn = "-- Not Available --";
                    string AdSpontEnergen_Ginger = "-- Not Available --";
                    string AdSpontEnergen_unspec = "-- Not Available --";
                    string AdSpontEnergen_Go_Fruit = "-- Not Available --";
                    string AdSpontNBear_Busog_Lusog_Orig = "-- Not Available --";
                    string AdSpontNBear_Brand_Busog_Lusog_Choco = "-- Not Available --";
                    string AdSpontNBear_Brand_Busog_Lusog_unspec = "-- Not Available --";
                    string AdSpontNestle_Koko_Krunch = "-- Not Available --";
                    string AdSpontNestle_Koko_Krunch_AllInOne = "-- Not Available --";
                    string AdSpontQuaker_Instant_Oatmeal = "-- Not Available --";
                    string AdSpontQuaker_Quick_Cook = "-- Not Available --";
                    string AdSpontQuaker_unspec = "-- Not Available --";
                    string AdSpontEC_Choco_Flakes = "-- Not Available --";
                    string AdSpontEC_Milky_Flakes = "-- Not Available --";
                    string AdSpontMilo = "-- Not Available --";
                    string AdAidEnergen_Vanilla = "-- Not Available --";
                    string AdAidEnergen_Choco = "-- Not Available --";
                    string AdAidEnergen_Sweet_Corn = "-- Not Available --";
                    string AdAidEnergen_Ginger = "-- Not Available --";
                    string AdAidEnergen_unspec = "-- Not Available --";
                    string AdAidEnergen_Go_Fruit = "-- Not Available --";
                    string AdAidNBear_Busog_Lusog_Orig = "-- Not Available --";
                    string AdAidNBear_Brand_Busog_Lusog_Choco = "-- Not Available --";
                    string AdAidNBear_Brand_Busog_Lusog_unspec = "-- Not Available --";
                    string AdAidNestle_Koko_Krunch = "-- Not Available --";
                    string AdAidNestle_Koko_Krunch_AllInOne = "-- Not Available --";
                    string AdAidQuaker_Instant_Oatmeal = "-- Not Available --";
                    string AdAidQuaker_Quick_Cook = "-- Not Available --";
                    string AdAidQuaker_unspec = "-- Not Available --";
                    string AdAidEC_Choco_Flakes = "-- Not Available --";
                    string AdAidEC_Milky_Flakes = "-- Not Available --";
                    string AdAidMilo = "-- Not Available --";
                    string ConL3MEnergen_Vanilla = "-- Not Available --";
                    string ConL3MEnergen_Choco = "-- Not Available --";
                    string ConL3MEnergen_Sweet_Corn = "-- Not Available --";
                    string ConL3MEnergen_Ginger = "-- Not Available --";
                    string ConL3MEnergen_unspec = "-- Not Available --";
                    string ConL3MEnergen_Go_Fruit = "-- Not Available --";
                    string ConL3MNBear_Busog_Lusog_Orig = "-- Not Available --";
                    string ConL3MNBear_Brand_Busog_Lusog_Choco = "-- Not Available --";
                    string ConL3MNBear_Brand_Busog_Lusog_unspec = "-- Not Available --";
                    string ConL3MNestle_Koko_Krunch = "-- Not Available --";
                    string ConL3MNestle_Koko_Krunch_AllInOne = "-- Not Available --";
                    string ConL3MQuaker_Instant_Oatmeal = "-- Not Available --";
                    string ConL3MQuaker_Quick_Cook = "-- Not Available --";
                    string ConL3MQuaker_unspec = "-- Not Available --";
                    string ConL3MEC_Choco_Flakes = "-- Not Available --";
                    string ConL3MEC_Milky_Flakes = "-- Not Available --";
                    string ConL3MMilo = "-- Not Available --";
                    string EverTried_Energen_Vanilla = "-- Not Available --";
                    string EverTried_Energen_Choco = "-- Not Available --";
                    string EverTried_Energen_Sweet_Corn = "-- Not Available --";
                    string EverTried_Energen_Ginger = "-- Not Available --";
                    string EverTried_Energen_unspec = "-- Not Available --";
                    string EverTried_Energen_Go_Fruit = "-- Not Available --";
                    string EverTried_NBear_Busog_Lusog_Orig = "-- Not Available --";
                    string EverTried_NBear_Brand_Busog_Lusog_Choco = "-- Not Available --";
                    string EverTried_NBear_Brand_Busog_Lusog_unspec = "-- Not Available --";
                    string EverTried_Nestle_Koko_Krunch = "-- Not Available --";
                    string EverTried_Nestle_Koko_Krunch_AllInOne = "-- Not Available --";
                    string EverTried_Quaker_Instant_Oatmeal = "-- Not Available --";
                    string EverTried_Quaker_Quick_Cook = "-- Not Available --";
                    string EverTried_Quaker_unspec = "-- Not Available --";
                    string EverTried_EC_Choco_Flakes = "-- Not Available --";
                    string EverTried_EC_Milky_Flakes = "-- Not Available --";
                    string EverTried_Milo = "-- Not Available --";
                    string Q17_1_01 = "-- Not Available --";
                    string Q17_1_02 = "-- Not Available --";
                    string Q17_1_03 = "-- Not Available --";
                    string Q17_1_04 = "-- Not Available --";
                    string Q17_1_05 = "-- Not Available --";
                    string Q17_1_06 = "-- Not Available --";
                    string Q17_1_21 = "-- Not Available --";
                    string Q17_1_22 = "-- Not Available --";
                    string Q17_1_23 = "-- Not Available --";
                    string Q17_1_28 = "-- Not Available --";
                    string Q17_1_34 = "-- Not Available --";
                    string Q17_1_41 = "-- Not Available --";
                    string Q17_1_42 = "-- Not Available --";
                    string Q17_1_44 = "-- Not Available --";
                    string Q17_1_54 = "-- Not Available --";
                    string Q17_1_55 = "-- Not Available --";
                    string Q17_1_78 = "-- Not Available --";
                    string Q17_2_01 = "-- Not Available --";
                    string Q17_2_02 = "-- Not Available --";
                    string Q17_2_03 = "-- Not Available --";
                    string Q17_2_04 = "-- Not Available --";
                    string Q17_2_05 = "-- Not Available --";
                    string Q17_2_06 = "-- Not Available --";
                    string Q17_2_21 = "-- Not Available --";
                    string Q17_2_22 = "-- Not Available --";
                    string Q17_2_23 = "-- Not Available --";
                    string Q17_2_28 = "-- Not Available --";
                    string Q17_2_34 = "-- Not Available --";
                    string Q17_2_41 = "-- Not Available --";
                    string Q17_2_42 = "-- Not Available --";
                    string Q17_2_44 = "-- Not Available --";
                    string Q17_2_54 = "-- Not Available --";
                    string Q17_2_55 = "-- Not Available --";
                    string Q17_2_78 = "-- Not Available --";
                    string Q17_3_01 = "-- Not Available --";
                    string Q17_3_02 = "-- Not Available --";
                    string Q17_3_03 = "-- Not Available --";
                    string Q17_3_04 = "-- Not Available --";
                    string Q17_3_05 = "-- Not Available --";
                    string Q17_3_06 = "-- Not Available --";
                    string Q17_3_21 = "-- Not Available --";
                    string Q17_3_22 = "-- Not Available --";
                    string Q17_3_23 = "-- Not Available --";
                    string Q17_3_28 = "-- Not Available --";
                    string Q17_3_34 = "-- Not Available --";
                    string Q17_3_41 = "-- Not Available --";
                    string Q17_3_42 = "-- Not Available --";
                    string Q17_3_44 = "-- Not Available --";
                    string Q17_3_54 = "-- Not Available --";
                    string Q17_3_55 = "-- Not Available --";
                    string Q17_3_78 = "-- Not Available --";
                    string Q17_4_01 = "-- Not Available --";
                    string Q17_4_02 = "-- Not Available --";
                    string Q17_4_03 = "-- Not Available --";
                    string Q17_4_04 = "-- Not Available --";
                    string Q17_4_05 = "-- Not Available --";
                    string Q17_4_06 = "-- Not Available --";
                    string Q17_4_21 = "-- Not Available --";
                    string Q17_4_22 = "-- Not Available --";
                    string Q17_4_23 = "-- Not Available --";
                    string Q17_4_28 = "-- Not Available --";
                    string Q17_4_34 = "-- Not Available --";
                    string Q17_4_41 = "-- Not Available --";
                    string Q17_4_42 = "-- Not Available --";
                    string Q17_4_44 = "-- Not Available --";
                    string Q17_4_54 = "-- Not Available --";
                    string Q17_4_55 = "-- Not Available --";
                    string Q17_4_78 = "-- Not Available --";
                    string Q17_5_01 = "-- Not Available --";
                    string Q17_5_02 = "-- Not Available --";
                    string Q17_5_03 = "-- Not Available --";
                    string Q17_5_04 = "-- Not Available --";
                    string Q17_5_05 = "-- Not Available --";
                    string Q17_5_06 = "-- Not Available --";
                    string Q17_5_21 = "-- Not Available --";
                    string Q17_5_22 = "-- Not Available --";
                    string Q17_5_23 = "-- Not Available --";
                    string Q17_5_28 = "-- Not Available --";
                    string Q17_5_34 = "-- Not Available --";
                    string Q17_5_41 = "-- Not Available --";
                    string Q17_5_42 = "-- Not Available --";
                    string Q17_5_44 = "-- Not Available --";
                    string Q17_5_54 = "-- Not Available --";
                    string Q17_5_55 = "-- Not Available --";
                    string Q17_5_78 = "-- Not Available --";
                    string Bumo = "-- Not Available --";
                    string PreBumo = "-- Not Available --";
                    string FavouriteBrand = "-- Not Available --";
                    string Q22 = "-- Not Available --";
                    string Q23_SUBNET = "-- Not Available --";
                    string BrTom_NET = "-- Not Available --";
                    string BrSpont_EnergenNET = "-- Not Available --";
                    string BrSpont_NBear_Brand_Busog_LusogNET = "-- Not Available --";
                    string Q11_82 = "-- Not Available --";
                    string Q11_85 = "-- Not Available --";
                    string Q11_88 = "-- Not Available --";
                    string BrAid_EnergenNET = "-- Not Available --";
                    string BrAid_NBear_Brand_Busog_LusogNET = "-- Not Available --";
                    string Q13_82 = "-- Not Available --";
                    string Q13_85 = "-- Not Available --";
                    string Q13_88 = "-- Not Available --";
                    string AdTom_NET = "-- Not Available --";
                    string AdSpont_EnergenNET = "-- Not Available --";
                    string AdSpont_NBear_Brand_Busog_LusogNET = "-- Not Available --";
                    string Q12_82 = "-- Not Available --";
                    string Q12_85 = "-- Not Available --";
                    string Q12_88 = "-- Not Available --";
                    string AdAid_EnergenNET = "-- Not Available --";
                    string AdAid_NBear_Brand_Busog_LusogNET = "-- Not Available --";
                    string Q12Q14_82 = "-- Not Available --";
                    string Q12Q14_85 = "-- Not Available --";
                    string Q12Q14_88 = "-- Not Available --";
                    string EverTried_EnergenNET = "-- Not Available --";
                    string EverTried_NBear_Brand_Busog_LusogNET = "-- Not Available --";
                    string Q15Q16_82 = "-- Not Available --";
                    string Q15Q16_85 = "-- Not Available --";
                    string Q15Q16_88 = "-- Not Available --";
                    string ConsP3M_EnergenNET = "-- Not Available --";
                    string ConsP3M_NBear_Brand_Busog_LusogNET = "-- Not Available --";
                    string Q18_82 = "-- Not Available --";
                    string Q18_85 = "-- Not Available --";
                    string Q18_88 = "-- Not Available --";
                    string NetBumo = "-- Not Available --";
                    string NetFavouriteBrand = "-- Not Available --";
                    string NetPreBumo = "-- Not Available --";
                    string Q23_NET = "-- Not Available --";
                    string Q52_5001_01 = "-- Not Available --";
                    string Q52_5001_02 = "-- Not Available --";
                    string Q52_5001_03 = "-- Not Available --";
                    string Q52_5001_04 = "-- Not Available --";
                    string Q52_5001_05 = "-- Not Available --";
                    string Q52_5001_06 = "-- Not Available --";
                    string Q52_5001_07 = "-- Not Available --";
                    string Q52_5001_08 = "-- Not Available --";
                    string Q52_5001_09 = "-- Not Available --";
                    string Q52_5001_10 = "-- Not Available --";
                    string Q52_5001_11 = "-- Not Available --";
                    string Q52_5001_12 = "-- Not Available --";
                    string Q52_6001_01 = "-- Not Available --";
                    string Q52_6001_02 = "-- Not Available --";
                    string Q52_6001_03 = "-- Not Available --";
                    string Q52_6001_04 = "-- Not Available --";
                    string Q52_6001_05 = "-- Not Available --";
                    string Q52_6001_06 = "-- Not Available --";
                    string Q52_6001_07 = "-- Not Available --";
                    string Q52_6001_08 = "-- Not Available --";
                    string Q52_6001_09 = "-- Not Available --";
                    string Q52_6001_10 = "-- Not Available --";
                    string Q52_6001_11 = "-- Not Available --";
                    string Q52_6001_12 = "-- Not Available --";
                    string Q17_1_79 = "-- Not Available --";
                    string Q17_1_80 = "-- Not Available --";
                    string Q17_1_82 = "-- Not Available --";
                    string Q17_1_85 = "-- Not Available --";
                    string Q17_1_88 = "-- Not Available --";
                    string Q17_2_79 = "-- Not Available --";
                    string Q17_2_80 = "-- Not Available --";
                    string Q17_2_82 = "-- Not Available --";
                    string Q17_2_85 = "-- Not Available --";
                    string Q17_2_88 = "-- Not Available --";
                    string Q17_3_79 = "-- Not Available --";
                    string Q17_3_80 = "-- Not Available --";
                    string Q17_3_82 = "-- Not Available --";
                    string Q17_3_85 = "-- Not Available --";
                    string Q17_3_88 = "-- Not Available --";
                    string Q17_4_79 = "-- Not Available --";
                    string Q17_4_80 = "-- Not Available --";
                    string Q17_4_82 = "-- Not Available --";
                    string Q17_4_85 = "-- Not Available --";
                    string Q17_4_88 = "-- Not Available --";
                    string Q17_5_79 = "-- Not Available --";
                    string Q17_5_80 = "-- Not Available --";
                    string Q17_5_82 = "-- Not Available --";
                    string Q17_5_85 = "-- Not Available --";
                    string Q17_5_88 = "-- Not Available --";
                    string Q32_5001_03 = "-- Not Available --";
                    string Q32_5001_04 = "-- Not Available --";
                    string Q32_5001_06 = "-- Not Available --";
                    string Q32_5001_07 = "-- Not Available --";
                    string Q32_5001_08 = "-- Not Available --";
                    string Q32_5001_14 = "-- Not Available --";
                    string Q32_5001_20 = "-- Not Available --";
                    string Q32_5001_21 = "-- Not Available --";
                    string Q32_6001_03 = "-- Not Available --";
                    string Q32_6001_04 = "-- Not Available --";
                    string Q32_6001_06 = "-- Not Available --";
                    string Q32_6001_07 = "-- Not Available --";
                    string Q32_6001_08 = "-- Not Available --";
                    string Q32_6001_14 = "-- Not Available --";
                    string Q32_6001_20 = "-- Not Available --";
                    string Q32_6001_21 = "-- Not Available --";
                    string Q32_7001_03 = "-- Not Available --";
                    string Q32_7001_04 = "-- Not Available --";
                    string Q32_7001_06 = "-- Not Available --";
                    string Q32_7001_07 = "-- Not Available --";
                    string Q32_7001_08 = "-- Not Available --";
                    string Q32_7001_14 = "-- Not Available --";
                    string Q32_7001_20 = "-- Not Available --";
                    string Q32_7001_21 = "-- Not Available --";
                    string Q32_81_03 = "-- Not Available --";
                    string Q32_81_04 = "-- Not Available --";
                    string Q32_81_06 = "-- Not Available --";
                    string Q32_81_07 = "-- Not Available --";
                    string Q32_81_08 = "-- Not Available --";
                    string Q32_81_14 = "-- Not Available --";
                    string Q32_81_20 = "-- Not Available --";
                    string Q32_81_21 = "-- Not Available --";
                    string Q32_136_03 = "-- Not Available --";
                    string Q32_136_04 = "-- Not Available --";
                    string Q32_136_06 = "-- Not Available --";
                    string Q32_136_07 = "-- Not Available --";
                    string Q32_136_08 = "-- Not Available --";
                    string Q32_136_14 = "-- Not Available --";
                    string Q32_136_20 = "-- Not Available --";
                    string Q32_136_21 = "-- Not Available --";
                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;
                                switch (variable_name)
                                {

                                    case "Respondent_ID":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, AttendedOn, u_id);
                                            break;
                                        }
                                    case "WEIGHT_BAN123":
                                        {
                                            Weight = Convert.ToDecimal(record.GetValue(variable));
                                            break;
                                        }
                                    case "BAREA":
                                        {
                                            Location = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "WAVE":
                                        {
                                            Period = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "S2":
                                        {
                                            Gender = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q60":
                                        {
                                            MaritalStatus = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Ban_age":
                                        {
                                            AgeGroup = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "S6":
                                        {
                                            Ses = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q62":
                                        {
                                            Occupation = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q61":
                                        {
                                            Education = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q10_SUBNET":
                                        {
                                            BrTom = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_01":
                                        {
                                            BrSpontEnergen_Vanilla = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_02":
                                        {
                                            BrSpontEnergen_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_03":
                                        {
                                            BrSpontEnergen_Sweet_Corn = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_04":
                                        {
                                            BrSpontEnergen_Ginger = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_05":
                                        {
                                            BrSpontEnergen_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_06":
                                        {
                                            BrSpontEnergen_Go_Fruit = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_09":
                                        {
                                            BrSpontNBear_Busog_Lusog_Orig = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_10":
                                        {
                                            BrSpontNBear_Brand_Busog_Lusog_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_11":
                                        {
                                            BrSpontNBear_Brand_Busog_Lusog_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_19":
                                        {
                                            BrSpontNestle_Koko_Krunch = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_20":
                                        {
                                            BrSpontNestle_Koko_Krunch_AllInOne = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_31":
                                        {
                                            BrSpontQuaker_Instant_Oatmeal = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_32":
                                        {
                                            BrSpontQuaker_Quick_Cook = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_45":
                                        {
                                            BrSpontQuaker_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_54":
                                        {
                                            BrSpontEC_Choco_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_55":
                                        {
                                            BrSpontEC_Milky_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_78":
                                        {
                                            BrSpontMilo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_01":
                                        {
                                            BrAidEnergen_Vanilla = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_02":
                                        {
                                            BrAidEnergen_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_03":
                                        {
                                            BrAidEnergen_Sweet_Corn = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_04":
                                        {
                                            BrAidEnergen_Ginger = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_05":
                                        {
                                            BrAidEnergen_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_06":
                                        {
                                            BrAidEnergen_Go_Fruit = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_09":
                                        {
                                            BrAidNBear_Busog_Lusog_Orig = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_10":
                                        {
                                            BrAidNBear_Brand_Busog_Lusog_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_11":
                                        {
                                            BrAidNBear_Brand_Busog_Lusog_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_19":
                                        {
                                            BrAidNestle_Koko_Krunch = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_20":
                                        {
                                            BrAidNestle_Koko_Krunch_AllInOne = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_31":
                                        {
                                            BrAidQuaker_Instant_Oatmeal = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_32":
                                        {
                                            BrAidQuaker_Quick_Cook = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_45":
                                        {
                                            BrAidQuaker_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_54":
                                        {
                                            BrAidEC_Choco_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_55":
                                        {
                                            BrAidEC_Milky_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_78":
                                        {
                                            BrAidMilo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12TOM_SUBNET":
                                        {
                                            AdTom = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_01":
                                        {
                                            AdSpontEnergen_Vanilla = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_02":
                                        {
                                            AdSpontEnergen_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_03":
                                        {
                                            AdSpontEnergen_Sweet_Corn = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_04":
                                        {
                                            AdSpontEnergen_Ginger = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_05":
                                        {
                                            AdSpontEnergen_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_06":
                                        {
                                            AdSpontEnergen_Go_Fruit = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_09":
                                        {
                                            AdSpontNBear_Busog_Lusog_Orig = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_10":
                                        {
                                            AdSpontNBear_Brand_Busog_Lusog_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_11":
                                        {
                                            AdSpontNBear_Brand_Busog_Lusog_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_19":
                                        {
                                            AdSpontNestle_Koko_Krunch = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_20":
                                        {
                                            AdSpontNestle_Koko_Krunch_AllInOne = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_31":
                                        {
                                            AdSpontQuaker_Instant_Oatmeal = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_32":
                                        {
                                            AdSpontQuaker_Quick_Cook = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_45":
                                        {
                                            AdSpontQuaker_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_54":
                                        {
                                            AdSpontEC_Choco_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_55":
                                        {
                                            AdSpontEC_Milky_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_78":
                                        {
                                            AdSpontMilo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_01":
                                        {
                                            AdAidEnergen_Vanilla = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_02":
                                        {
                                            AdAidEnergen_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_03":
                                        {
                                            AdAidEnergen_Sweet_Corn = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_04":
                                        {
                                            AdAidEnergen_Ginger = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_05":
                                        {
                                            AdAidEnergen_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_06":
                                        {
                                            AdAidEnergen_Go_Fruit = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_09":
                                        {
                                            AdAidNBear_Busog_Lusog_Orig = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_10":
                                        {
                                            AdAidNBear_Brand_Busog_Lusog_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_11":
                                        {
                                            AdAidNBear_Brand_Busog_Lusog_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_19":
                                        {
                                            AdAidNestle_Koko_Krunch = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_20":
                                        {
                                            AdAidNestle_Koko_Krunch_AllInOne = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_31":
                                        {
                                            AdAidQuaker_Instant_Oatmeal = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_32":
                                        {
                                            AdAidQuaker_Quick_Cook = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_45":
                                        {
                                            AdAidQuaker_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_54":
                                        {
                                            AdAidEC_Choco_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_55":
                                        {
                                            AdAidEC_Milky_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_78":
                                        {
                                            AdAidMilo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_01":
                                        {
                                            ConL3MEnergen_Vanilla = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_02":
                                        {
                                            ConL3MEnergen_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_03":
                                        {
                                            ConL3MEnergen_Sweet_Corn = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_04":
                                        {
                                            ConL3MEnergen_Ginger = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_05":
                                        {
                                            ConL3MEnergen_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_06":
                                        {
                                            ConL3MEnergen_Go_Fruit = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_09":
                                        {
                                            ConL3MNBear_Busog_Lusog_Orig = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_10":
                                        {
                                            ConL3MNBear_Brand_Busog_Lusog_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_11":
                                        {
                                            ConL3MNBear_Brand_Busog_Lusog_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_19":
                                        {
                                            ConL3MNestle_Koko_Krunch = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_20":
                                        {
                                            ConL3MNestle_Koko_Krunch_AllInOne = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_31":
                                        {
                                            ConL3MQuaker_Instant_Oatmeal = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_32":
                                        {
                                            ConL3MQuaker_Quick_Cook = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_45":
                                        {
                                            ConL3MQuaker_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_54":
                                        {
                                            ConL3MEC_Choco_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_55":
                                        {
                                            ConL3MEC_Milky_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_78":
                                        {
                                            ConL3MMilo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_01":
                                        {
                                            EverTried_Energen_Vanilla = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_02":
                                        {
                                            EverTried_Energen_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_03":
                                        {
                                            EverTried_Energen_Sweet_Corn = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_04":
                                        {
                                            EverTried_Energen_Ginger = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_05":
                                        {
                                            EverTried_Energen_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_06":
                                        {
                                            EverTried_Energen_Go_Fruit = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_09":
                                        {
                                            EverTried_NBear_Busog_Lusog_Orig = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_10":
                                        {
                                            EverTried_NBear_Brand_Busog_Lusog_Choco = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_11":
                                        {
                                            EverTried_NBear_Brand_Busog_Lusog_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_19":
                                        {
                                            EverTried_Nestle_Koko_Krunch = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_20":
                                        {
                                            EverTried_Nestle_Koko_Krunch_AllInOne = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_31":
                                        {
                                            EverTried_Quaker_Instant_Oatmeal = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_32":
                                        {
                                            EverTried_Quaker_Quick_Cook = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_45":
                                        {
                                            EverTried_Quaker_unspec = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_54":
                                        {
                                            EverTried_EC_Choco_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_55":
                                        {
                                            EverTried_EC_Milky_Flakes = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_78":
                                        {
                                            EverTried_Milo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_01":
                                        {
                                            Q17_1_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_02":
                                        {
                                            Q17_1_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_03":
                                        {
                                            Q17_1_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_04":
                                        {
                                            Q17_1_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_05":
                                        {
                                            Q17_1_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_06":
                                        {
                                            Q17_1_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_21":
                                        {
                                            Q17_1_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_22":
                                        {
                                            Q17_1_22 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_23":
                                        {
                                            Q17_1_23 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_28":
                                        {
                                            Q17_1_28 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_34":
                                        {
                                            Q17_1_34 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_41":
                                        {
                                            Q17_1_41 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_42":
                                        {
                                            Q17_1_42 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_44":
                                        {
                                            Q17_1_44 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_54":
                                        {
                                            Q17_1_54 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_55":
                                        {
                                            Q17_1_55 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_78":
                                        {
                                            Q17_1_78 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_01":
                                        {
                                            Q17_2_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_02":
                                        {
                                            Q17_2_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_03":
                                        {
                                            Q17_2_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_04":
                                        {
                                            Q17_2_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_05":
                                        {
                                            Q17_2_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_06":
                                        {
                                            Q17_2_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_21":
                                        {
                                            Q17_2_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_22":
                                        {
                                            Q17_2_22 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_23":
                                        {
                                            Q17_2_23 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_28":
                                        {
                                            Q17_2_28 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_34":
                                        {
                                            Q17_2_34 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_41":
                                        {
                                            Q17_2_41 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_42":
                                        {
                                            Q17_2_42 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_44":
                                        {
                                            Q17_2_44 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_54":
                                        {
                                            Q17_2_54 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_55":
                                        {
                                            Q17_2_55 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_78":
                                        {
                                            Q17_2_78 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_01":
                                        {
                                            Q17_3_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_02":
                                        {
                                            Q17_3_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_03":
                                        {
                                            Q17_3_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_04":
                                        {
                                            Q17_3_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_05":
                                        {
                                            Q17_3_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_06":
                                        {
                                            Q17_3_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_21":
                                        {
                                            Q17_3_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_22":
                                        {
                                            Q17_3_22 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_23":
                                        {
                                            Q17_3_23 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_28":
                                        {
                                            Q17_3_28 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_34":
                                        {
                                            Q17_3_34 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_41":
                                        {
                                            Q17_3_41 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_42":
                                        {
                                            Q17_3_42 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_44":
                                        {
                                            Q17_3_44 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_54":
                                        {
                                            Q17_3_54 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_55":
                                        {
                                            Q17_3_55 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_78":
                                        {
                                            Q17_3_78 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_01":
                                        {
                                            Q17_4_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_02":
                                        {
                                            Q17_4_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_03":
                                        {
                                            Q17_4_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_04":
                                        {
                                            Q17_4_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_05":
                                        {
                                            Q17_4_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_06":
                                        {
                                            Q17_4_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_21":
                                        {
                                            Q17_4_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_22":
                                        {
                                            Q17_4_22 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_23":
                                        {
                                            Q17_4_23 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_28":
                                        {
                                            Q17_4_28 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_34":
                                        {
                                            Q17_4_34 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_41":
                                        {
                                            Q17_4_41 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_42":
                                        {
                                            Q17_4_42 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_44":
                                        {
                                            Q17_4_44 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_54":
                                        {
                                            Q17_4_54 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_55":
                                        {
                                            Q17_4_55 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_78":
                                        {
                                            Q17_4_78 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_01":
                                        {
                                            Q17_5_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_02":
                                        {
                                            Q17_5_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_03":
                                        {
                                            Q17_5_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_04":
                                        {
                                            Q17_5_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_05":
                                        {
                                            Q17_5_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_06":
                                        {
                                            Q17_5_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_21":
                                        {
                                            Q17_5_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_22":
                                        {
                                            Q17_5_22 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_23":
                                        {
                                            Q17_5_23 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_28":
                                        {
                                            Q17_5_28 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_34":
                                        {
                                            Q17_5_34 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_41":
                                        {
                                            Q17_5_41 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_42":
                                        {
                                            Q17_5_42 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_44":
                                        {
                                            Q17_5_44 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_54":
                                        {
                                            Q17_5_54 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_55":
                                        {
                                            Q17_5_55 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_78":
                                        {
                                            Q17_5_78 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q19_SUBNET":
                                        {
                                            Bumo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q20_SUBNET":
                                        {
                                            PreBumo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q21_SUBNET":
                                        {
                                            FavouriteBrand = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q22":
                                        {
                                            Q22 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q23_SUBNET":
                                        {
                                            Q23_SUBNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q10_NET":
                                        {
                                            BrTom_NET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_79":
                                        {
                                            BrSpont_EnergenNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_80":
                                        {
                                            BrSpont_NBear_Brand_Busog_LusogNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_82":
                                        {
                                            Q11_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_85":
                                        {
                                            Q11_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q11_88":
                                        {
                                            Q11_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_79":
                                        {
                                            BrAid_EnergenNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_80":
                                        {
                                            BrAid_NBear_Brand_Busog_LusogNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_82":
                                        {
                                            Q13_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_85":
                                        {
                                            Q13_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q13_88":
                                        {
                                            Q13_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12TOM_NET":
                                        {
                                            AdTom_NET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_79":
                                        {
                                            AdSpont_EnergenNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_80":
                                        {
                                            AdSpont_NBear_Brand_Busog_LusogNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_82":
                                        {
                                            Q12_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_85":
                                        {
                                            Q12_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12_88":
                                        {
                                            Q12_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_79":
                                        {
                                            AdAid_EnergenNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_80":
                                        {
                                            AdAid_NBear_Brand_Busog_LusogNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_82":
                                        {
                                            Q12Q14_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_85":
                                        {
                                            Q12Q14_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q12Q14_88":
                                        {
                                            Q12Q14_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_79":
                                        {
                                            EverTried_EnergenNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_80":
                                        {
                                            EverTried_NBear_Brand_Busog_LusogNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_82":
                                        {
                                            Q15Q16_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_85":
                                        {
                                            Q15Q16_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q15Q16_88":
                                        {
                                            Q15Q16_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_79":
                                        {
                                            ConsP3M_EnergenNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_80":
                                        {
                                            ConsP3M_NBear_Brand_Busog_LusogNET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_82":
                                        {
                                            Q18_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_85":
                                        {
                                            Q18_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q18_88":
                                        {
                                            Q18_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q19_NET":
                                        {
                                            NetBumo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q21_NET":
                                        {
                                            NetFavouriteBrand = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q20_NET":
                                        {
                                            NetPreBumo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q23_NET":
                                        {
                                            Q23_NET = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_01":
                                        {
                                            Q52_5001_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_02":
                                        {
                                            Q52_5001_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_03":
                                        {
                                            Q52_5001_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_04":
                                        {
                                            Q52_5001_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_05":
                                        {
                                            Q52_5001_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_06":
                                        {
                                            Q52_5001_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_07":
                                        {
                                            Q52_5001_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_08":
                                        {
                                            Q52_5001_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_09":
                                        {
                                            Q52_5001_09 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_10":
                                        {
                                            Q52_5001_10 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_11":
                                        {
                                            Q52_5001_11 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_5001_12":
                                        {
                                            Q52_5001_12 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_01":
                                        {
                                            Q52_6001_01 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_02":
                                        {
                                            Q52_6001_02 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_03":
                                        {
                                            Q52_6001_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_04":
                                        {
                                            Q52_6001_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_05":
                                        {
                                            Q52_6001_05 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_06":
                                        {
                                            Q52_6001_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_07":
                                        {
                                            Q52_6001_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_08":
                                        {
                                            Q52_6001_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_09":
                                        {
                                            Q52_6001_09 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_10":
                                        {
                                            Q52_6001_10 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_11":
                                        {
                                            Q52_6001_11 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q52_6001_12":
                                        {
                                            Q52_6001_12 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_79":
                                        {
                                            Q17_1_79 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_80":
                                        {
                                            Q17_1_80 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_82":
                                        {
                                            Q17_1_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_85":
                                        {
                                            Q17_1_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_1_88":
                                        {
                                            Q17_1_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_79":
                                        {
                                            Q17_2_79 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_80":
                                        {
                                            Q17_2_80 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_82":
                                        {
                                            Q17_2_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_85":
                                        {
                                            Q17_2_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_2_88":
                                        {
                                            Q17_2_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_79":
                                        {
                                            Q17_3_79 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_80":
                                        {
                                            Q17_3_80 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_82":
                                        {
                                            Q17_3_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_85":
                                        {
                                            Q17_3_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_3_88":
                                        {
                                            Q17_3_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_79":
                                        {
                                            Q17_4_79 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_80":
                                        {
                                            Q17_4_80 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_82":
                                        {
                                            Q17_4_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_85":
                                        {
                                            Q17_4_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_4_88":
                                        {
                                            Q17_4_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_79":
                                        {
                                            Q17_5_79 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_80":
                                        {
                                            Q17_5_80 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_82":
                                        {
                                            Q17_5_82 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_85":
                                        {
                                            Q17_5_85 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q17_5_88":
                                        {
                                            Q17_5_88 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_03":
                                        {
                                            Q32_5001_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_04":
                                        {
                                            Q32_5001_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_06":
                                        {
                                            Q32_5001_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_07":
                                        {
                                            Q32_5001_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_08":
                                        {
                                            Q32_5001_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_14":
                                        {
                                            Q32_5001_14 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_20":
                                        {
                                            Q32_5001_20 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_5001_21":
                                        {
                                            Q32_5001_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_03":
                                        {
                                            Q32_6001_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_04":
                                        {
                                            Q32_6001_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_06":
                                        {
                                            Q32_6001_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_07":
                                        {
                                            Q32_6001_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_08":
                                        {
                                            Q32_6001_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_14":
                                        {
                                            Q32_6001_14 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_20":
                                        {
                                            Q32_6001_20 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_6001_21":
                                        {
                                            Q32_6001_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_03":
                                        {
                                            Q32_7001_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_04":
                                        {
                                            Q32_7001_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_06":
                                        {
                                            Q32_7001_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_07":
                                        {
                                            Q32_7001_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_08":
                                        {
                                            Q32_7001_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_14":
                                        {
                                            Q32_7001_14 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_20":
                                        {
                                            Q32_7001_20 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_7001_21":
                                        {
                                            Q32_7001_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_03":
                                        {
                                            Q32_81_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_04":
                                        {
                                            Q32_81_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_06":
                                        {
                                            Q32_81_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_07":
                                        {
                                            Q32_81_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_08":
                                        {
                                            Q32_81_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_14":
                                        {
                                            Q32_81_14 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_20":
                                        {
                                            Q32_81_20 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_81_21":
                                        {
                                            Q32_81_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_03":
                                        {
                                            Q32_136_03 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_04":
                                        {
                                            Q32_136_04 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_06":
                                        {
                                            Q32_136_06 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_07":
                                        {
                                            Q32_136_07 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_08":
                                        {
                                            Q32_136_08 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_14":
                                        {
                                            Q32_136_14 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_20":
                                        {
                                            Q32_136_20 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "Q32_136_21":
                                        {
                                            Q32_136_21 = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_Dashboard_values(userID, SurveyID, AttendedOn, Weight, country, Period, Location, Gender, MaritalStatus, AgeGroup, Ses, Occupation, Education, BrTom, BrSpontEnergen_Vanilla, BrSpontEnergen_Choco, BrSpontEnergen_Sweet_Corn, BrSpontEnergen_Ginger, BrSpontEnergen_unspec, BrSpontEnergen_Go_Fruit, BrSpontNBear_Busog_Lusog_Orig, BrSpontNBear_Brand_Busog_Lusog_Choco, BrSpontNBear_Brand_Busog_Lusog_unspec, BrSpontNestle_Koko_Krunch, BrSpontNestle_Koko_Krunch_AllInOne, BrSpontQuaker_Instant_Oatmeal, BrSpontQuaker_Quick_Cook, BrSpontQuaker_unspec, BrSpontEC_Choco_Flakes, BrSpontEC_Milky_Flakes, BrSpontMilo, BrAidEnergen_Vanilla, BrAidEnergen_Choco, BrAidEnergen_Sweet_Corn, BrAidEnergen_Ginger, BrAidEnergen_unspec, BrAidEnergen_Go_Fruit, BrAidNBear_Busog_Lusog_Orig, BrAidNBear_Brand_Busog_Lusog_Choco, BrAidNBear_Brand_Busog_Lusog_unspec, BrAidNestle_Koko_Krunch, BrAidNestle_Koko_Krunch_AllInOne, BrAidQuaker_Instant_Oatmeal, BrAidQuaker_Quick_Cook, BrAidQuaker_unspec, BrAidEC_Choco_Flakes, BrAidEC_Milky_Flakes, BrAidMilo, AdTom, AdSpontEnergen_Vanilla, AdSpontEnergen_Choco, AdSpontEnergen_Sweet_Corn, AdSpontEnergen_Ginger, AdSpontEnergen_unspec, AdSpontEnergen_Go_Fruit, AdSpontNBear_Busog_Lusog_Orig, AdSpontNBear_Brand_Busog_Lusog_Choco, AdSpontNBear_Brand_Busog_Lusog_unspec, AdSpontNestle_Koko_Krunch, AdSpontNestle_Koko_Krunch_AllInOne, AdSpontQuaker_Instant_Oatmeal, AdSpontQuaker_Quick_Cook, AdSpontQuaker_unspec, AdSpontEC_Choco_Flakes, AdSpontEC_Milky_Flakes, AdSpontMilo, AdAidEnergen_Vanilla, AdAidEnergen_Choco, AdAidEnergen_Sweet_Corn, AdAidEnergen_Ginger, AdAidEnergen_unspec, AdAidEnergen_Go_Fruit, AdAidNBear_Busog_Lusog_Orig, AdAidNBear_Brand_Busog_Lusog_Choco, AdAidNBear_Brand_Busog_Lusog_unspec, AdAidNestle_Koko_Krunch, AdAidNestle_Koko_Krunch_AllInOne, AdAidQuaker_Instant_Oatmeal, AdAidQuaker_Quick_Cook, AdAidQuaker_unspec, AdAidEC_Choco_Flakes, AdAidEC_Milky_Flakes, AdAidMilo, ConL3MEnergen_Vanilla, ConL3MEnergen_Choco, ConL3MEnergen_Sweet_Corn, ConL3MEnergen_Ginger, ConL3MEnergen_unspec, ConL3MEnergen_Go_Fruit, ConL3MNBear_Busog_Lusog_Orig, ConL3MNBear_Brand_Busog_Lusog_Choco, ConL3MNBear_Brand_Busog_Lusog_unspec, ConL3MNestle_Koko_Krunch, ConL3MNestle_Koko_Krunch_AllInOne, ConL3MQuaker_Instant_Oatmeal, ConL3MQuaker_Quick_Cook, ConL3MQuaker_unspec, ConL3MEC_Choco_Flakes, ConL3MEC_Milky_Flakes, ConL3MMilo, EverTried_Energen_Vanilla, EverTried_Energen_Choco, EverTried_Energen_Sweet_Corn, EverTried_Energen_Ginger, EverTried_Energen_unspec, EverTried_Energen_Go_Fruit, EverTried_NBear_Busog_Lusog_Orig, EverTried_NBear_Brand_Busog_Lusog_Choco, EverTried_NBear_Brand_Busog_Lusog_unspec, EverTried_Nestle_Koko_Krunch, EverTried_Nestle_Koko_Krunch_AllInOne, EverTried_Quaker_Instant_Oatmeal, EverTried_Quaker_Quick_Cook, EverTried_Quaker_unspec, EverTried_EC_Choco_Flakes, EverTried_EC_Milky_Flakes, EverTried_Milo, Q17_1_01, Q17_1_02, Q17_1_03, Q17_1_04, Q17_1_05, Q17_1_06, Q17_1_21, Q17_1_22, Q17_1_23, Q17_1_28, Q17_1_34, Q17_1_41, Q17_1_42, Q17_1_44, Q17_1_54, Q17_1_55, Q17_1_78, Q17_2_01, Q17_2_02, Q17_2_03, Q17_2_04, Q17_2_05, Q17_2_06, Q17_2_21, Q17_2_22, Q17_2_23, Q17_2_28, Q17_2_34, Q17_2_41, Q17_2_42, Q17_2_44, Q17_2_54, Q17_2_55, Q17_2_78, Q17_3_01, Q17_3_02, Q17_3_03, Q17_3_04, Q17_3_05, Q17_3_06, Q17_3_21, Q17_3_22, Q17_3_23, Q17_3_28, Q17_3_34, Q17_3_41, Q17_3_42, Q17_3_44, Q17_3_54, Q17_3_55, Q17_3_78, Q17_4_01, Q17_4_02, Q17_4_03, Q17_4_04, Q17_4_05, Q17_4_06, Q17_4_21, Q17_4_22, Q17_4_23, Q17_4_28, Q17_4_34, Q17_4_41, Q17_4_42, Q17_4_44, Q17_4_54, Q17_4_55, Q17_4_78, Q17_5_01, Q17_5_02, Q17_5_03, Q17_5_04, Q17_5_05, Q17_5_06, Q17_5_21, Q17_5_22, Q17_5_23, Q17_5_28, Q17_5_34, Q17_5_41, Q17_5_42, Q17_5_44, Q17_5_54, Q17_5_55, Q17_5_78, Bumo, PreBumo, FavouriteBrand, Q22, Q23_SUBNET, BrTom_NET, BrSpont_EnergenNET, BrSpont_NBear_Brand_Busog_LusogNET, Q11_82, Q11_85, Q11_88, BrAid_EnergenNET, BrAid_NBear_Brand_Busog_LusogNET, Q13_82, Q13_85, Q13_88, AdTom_NET, AdSpont_EnergenNET, AdSpont_NBear_Brand_Busog_LusogNET, Q12_82, Q12_85, Q12_88, AdAid_EnergenNET, AdAid_NBear_Brand_Busog_LusogNET, Q12Q14_82, Q12Q14_85, Q12Q14_88, EverTried_EnergenNET, EverTried_NBear_Brand_Busog_LusogNET, Q15Q16_82, Q15Q16_85, Q15Q16_88, ConsP3M_EnergenNET, ConsP3M_NBear_Brand_Busog_LusogNET, Q18_82, Q18_85, Q18_88, NetBumo, NetFavouriteBrand, NetPreBumo, Q23_NET, Q52_5001_01, Q52_5001_02, Q52_5001_03, Q52_5001_04, Q52_5001_05, Q52_5001_06, Q52_5001_07, Q52_5001_08, Q52_5001_09, Q52_5001_10, Q52_5001_11, Q52_5001_12, Q52_6001_01, Q52_6001_02, Q52_6001_03, Q52_6001_04, Q52_6001_05, Q52_6001_06, Q52_6001_07, Q52_6001_08, Q52_6001_09, Q52_6001_10, Q52_6001_11, Q52_6001_12, Q17_1_79, Q17_1_80, Q17_1_82, Q17_1_85, Q17_1_88, Q17_2_79, Q17_2_80, Q17_2_82, Q17_2_85, Q17_2_88, Q17_3_79, Q17_3_80, Q17_3_82, Q17_3_85, Q17_3_88, Q17_4_79, Q17_4_80, Q17_4_82, Q17_4_85, Q17_4_88, Q17_5_79, Q17_5_80, Q17_5_82, Q17_5_85, Q17_5_88, Q32_5001_03, Q32_5001_04, Q32_5001_06, Q32_5001_07, Q32_5001_08, Q32_5001_14, Q32_5001_20, Q32_5001_21, Q32_6001_03, Q32_6001_04, Q32_6001_06, Q32_6001_07, Q32_6001_08, Q32_6001_14, Q32_6001_20, Q32_6001_21, Q32_7001_03, Q32_7001_04, Q32_7001_06, Q32_7001_07, Q32_7001_08, Q32_7001_14, Q32_7001_20, Q32_7001_21, Q32_81_03, Q32_81_04, Q32_81_06, Q32_81_07, Q32_81_08, Q32_81_14, Q32_81_20, Q32_81_21, Q32_136_03, Q32_136_04, Q32_136_06, Q32_136_07, Q32_136_08, Q32_136_14, Q32_136_20, Q32_136_21);
                    }
                }
            }
        }
        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
}
