﻿using System.Collections.Generic;
using Database.Models;
using GTANetworkAPI;

public class CInteriorDefinition
{
	public CInteriorDefinition(string a_strDisplayName, string a_strIPLName, string strMapFileName, Vector3 a_vecPos, List<FurnitureRemoval> furnitureRemovals = null)
	{
		DisplayName = a_strDisplayName;
		IPLName = a_strIPLName;
		MapFileName = strMapFileName;
		Position = a_vecPos;
		FurnitureRemovals = furnitureRemovals;
	}

	public string DisplayName { get; }
	public string IPLName { get; }
	public string MapFileName { get; }
	public Vector3 Position { get; }
	public List<FurnitureRemoval> FurnitureRemovals { get; }
}

public static class InteriorDefinitions
{
	public static CInteriorDefinition GetInteriorDefinition(int interiorID)
	{
		if (interiorID != -1 && interiorID < g_InteriorDefinitions.Count)
		{
			return g_InteriorDefinitions[interiorID];
		}

		return null;
	}

	public static CInteriorDefinition GetInteriorDefinitionFromIPLName(string strIPLName)
	{
		foreach (CInteriorDefinition intDef in g_InteriorDefinitions)
		{
			if (intDef.IPLName.ToLower() == strIPLName.ToLower())
			{
				return intDef;
			}
		}

		return null;
	}

	private static List<CInteriorDefinition> g_InteriorDefinitions = new List<CInteriorDefinition>
	{
		new CInteriorDefinition("DesertBunker", "gr_case0_bunkerclosed", "", new Vector3(848.6175, 2996.567, 45.81612)),
		new CInteriorDefinition("SmokeTreeBunker", "gr_case1_bunkerclosed", "", new Vector3(2126.785, 3335.04, 48.21422)),
		new CInteriorDefinition("ScrapyardBunker", "gr_case2_bunkerclosed", "", new Vector3(2493.654, 3140.399, 51.28789)),
		new CInteriorDefinition("OilfieldsBunker", "gr_case3_bunkerclosed", "", new Vector3(481.0465, 2995.135, 43.96672)),
		new CInteriorDefinition("RatonCanyonBunker", "gr_case4_bunkerclosed", "", new Vector3(-391.3216, 4363.728, 58.65862)),
		new CInteriorDefinition("GrapeseedBunker", "gr_case5_bunkerclosed", "", new Vector3(1823.961, 4708.14, 42.4991)),
		new CInteriorDefinition("FarmhouseBunker", "gr_case6_bunkerclosed", "", new Vector3(1570.372, 2254.549, 78.89397)),
		new CInteriorDefinition("PalletoBunker", "gr_case7_bunkerclosed", "", new Vector3(-783.0755, 5934.686, 24.31475)),
		new CInteriorDefinition("Route68Bunker", "gr_case9_bunkerclosed", "", new Vector3(24.43542, 2959.705, 58.35517)),
		new CInteriorDefinition("ZancudoBunker", "gr_case10_bunkerclosed", "", new Vector3(-3058.714, 3329.19, 12.5844)),
		new CInteriorDefinition("Route1Bunker", "gr_case11_bunkerclosed", "", new Vector3(-3180.466, 1374.192, 19.9597)),
		new CInteriorDefinition("Modern 1 Apartment", "apa_v_mp_h_01_a", "", new Vector3(-786.8663, 315.7642, 217.6385)),
		new CInteriorDefinition("Modern 2 Apartment", "apa_v_mp_h_01_c", "", new Vector3(-786.9563, 315.6229, 187.9136)),
		new CInteriorDefinition("Modern 3 Apartment", "apa_v_mp_h_01_b", "", new Vector3(-774.0126, 342.0428, 196.6864)),
		new CInteriorDefinition("Mody 1 Apartment", "apa_v_mp_h_02_a", "", new Vector3(-787.0749, 315.8198, 217.6386)),
		new CInteriorDefinition("Mody 2 Apartment", "apa_v_mp_h_02_c", "", new Vector3(-786.8195, 315.5634, 187.9137)),
		new CInteriorDefinition("Mody 3 Apartment", "apa_v_mp_h_02_b", "", new Vector3(-774.1382, 342.0316, 196.6864)),
		new CInteriorDefinition("Vibrant 1 Apartment", "apa_v_mp_h_03_a", "", new Vector3(-786.6245, 315.6175, 217.6385)),
		new CInteriorDefinition("Vibrant 2 Apartment", "apa_v_mp_h_03_c", "", new Vector3(-786.9584, 315.7974, 187.9135)),
		new CInteriorDefinition("Vibrant 3 Apartment", "apa_v_mp_h_03_b", "", new Vector3(-774.0223, 342.1718, 196.6863)),
		new CInteriorDefinition("Sharp 1 Apartment", "apa_v_mp_h_04_a", "", new Vector3(-787.0902, 315.7039, 217.6384)),
		new CInteriorDefinition("Sharp 2 Apartment", "apa_v_mp_h_04_c", "", new Vector3(-787.0155, 315.7071, 187.9135)),
		new CInteriorDefinition("Sharp 3 Apartment", "apa_v_mp_h_04_b", "", new Vector3(-773.8976, 342.1525, 196.6863)),
		new CInteriorDefinition("Monochrome 1 Apartment", "apa_v_mp_h_05_a", "", new Vector3(-786.9887, 315.7393, 217.6386)),
		new CInteriorDefinition("Monochrome 2 Apartment", "apa_v_mp_h_05_c", "", new Vector3(-786.8809, 315.6634, 187.9136)),
		new CInteriorDefinition("Monochrome 3 Apartment", "apa_v_mp_h_05_b", "", new Vector3(-774.0675, 342.0773, 196.6864)),
		new CInteriorDefinition("Seductive 1 Apartment", "apa_v_mp_h_06_a", "", new Vector3(-787.1423, 315.6943, 217.6384)),
		new CInteriorDefinition("Seductive 2 Apartment", "apa_v_mp_h_06_c", "", new Vector3(-787.0961, 315.815, 187.9135)),
		new CInteriorDefinition("Seductive 3 Apartment", "apa_v_mp_h_06_b", "", new Vector3(-773.9552, 341.9892, 196.6862)),
		new CInteriorDefinition("Regal 1 Apartment", "apa_v_mp_h_07_a", "", new Vector3(-787.029, 315.7113, 217.6385)),
		new CInteriorDefinition("Regal 2 Apartment", "apa_v_mp_h_07_c", "", new Vector3(-787.0574, 315.6567, 187.9135)),
		new CInteriorDefinition("Regal 3 Apartment", "apa_v_mp_h_07_b", "", new Vector3(-774.0109, 342.0965, 196.6863)),
		new CInteriorDefinition("Aqua 1 Apartment", "apa_v_mp_h_08_a", "", new Vector3(-786.9469, 315.5655, 217.6383)),
		new CInteriorDefinition("Aqua 2 Apartment", "apa_v_mp_h_08_c", "", new Vector3(-786.9756, 315.723, 187.9134)),
		new CInteriorDefinition("Aqua 3 Apartment", "apa_v_mp_h_08_b", "", new Vector3(-774.0349, 342.0296, 196.6862)),
		new CInteriorDefinition("Executive Rich", "ex_dt1_02_office_02b", "", new Vector3(-141.1987, -620.913, 168.8205)),
		new CInteriorDefinition("Executive Cool", "ex_dt1_02_office_02c", "", new Vector3(-141.5429, -620.9524, 168.8204)),
		new CInteriorDefinition("Executive Contrast", "ex_dt1_02_office_02a", "", new Vector3(-141.2896, -620.9618, 168.8204)),
		new CInteriorDefinition("Old Spice Warm", "ex_dt1_02_office_01a", "", new Vector3(-141.4966, -620.8292, 168.8204)),
		new CInteriorDefinition("Old Spice Classical", "ex_dt1_02_office_01b", "", new Vector3(-141.3997, -620.9006, 168.8204)),
		new CInteriorDefinition("Old Spice Vintage", "ex_dt1_02_office_01c", "", new Vector3(-141.5361, -620.9186, 168.8204)),
		new CInteriorDefinition("Power Broker Ice", "ex_dt1_02_office_03a", "", new Vector3(-141.392, -621.0451, 168.8204)),
		new CInteriorDefinition("Power Broker Conservative", "ex_dt1_02_office_03b", "", new Vector3(-141.1945, -620.8729, 168.8204)),
		new CInteriorDefinition("Power Broker Polished", "ex_dt1_02_office_03c", "", new Vector3(-141.4924, -621.0035, 168.8205)),
		new CInteriorDefinition("Garage 1", "imp_dt1_02_cargarage_a", "", new Vector3(-191.0133, -579.1428, 135.0000)),
		new CInteriorDefinition("Garage 2", "imp_dt1_02_cargarage_b", "", new Vector3(-117.4989, -568.1132, 135.0000)),
		new CInteriorDefinition("Garage 3", "imp_dt1_02_cargarage_c", "", new Vector3(-136.0780, -630.1852, 135.0000)),
		new CInteriorDefinition("Mod Shop", "imp_dt1_02_modgarage", "", new Vector3(-146.6166, -596.6301, 166.0000)),
		new CInteriorDefinition("Executive Rich", "ex_dt1_11_office_02b", "", new Vector3(-75.8466, -826.9893, 243.3859)),
		new CInteriorDefinition("Executive Cool", "ex_dt1_11_office_02c", "", new Vector3(-75.49945, -827.05, 243.386)),
		new CInteriorDefinition("Executive Contrast", "ex_dt1_11_office_02a", "", new Vector3(-75.49827, -827.1889, 243.386)),
		new CInteriorDefinition("Old Spice Warm", "ex_dt1_11_office_01a", "", new Vector3(-75.44054, -827.1487, 243.3859)),
		new CInteriorDefinition("Old Spice Classical", "ex_dt1_11_office_01b", "", new Vector3(-75.63942, -827.1022, 243.3859)),
		new CInteriorDefinition("Old Spice Vintage", "ex_dt1_11_office_01c", "", new Vector3(-75.47446, -827.2621, 243.386)),
		new CInteriorDefinition("Power Broker Ice", "ex_dt1_11_office_03a", "", new Vector3(-75.56978, -827.1152, 243.3859)),
		new CInteriorDefinition("Power Broker Conservative", "ex_dt1_11_office_03b", "", new Vector3(-75.51953, -827.0786, 243.3859)),
		new CInteriorDefinition("Power Broker Polished", "ex_dt1_11_office_03c", "", new Vector3(-75.41915, -827.1118, 243.3858)),
		new CInteriorDefinition("Garage 1", "imp_dt1_11_cargarage_a", "", new Vector3(-84.2193, -823.0851, 221.0000)),
		new CInteriorDefinition("Garage 2", "imp_dt1_11_cargarage_b", "", new Vector3(-69.8627, -824.7498, 221.0000)),
		new CInteriorDefinition("Garage 3", "imp_dt1_11_cargarage_c", "", new Vector3(-80.4318, -813.2536, 221.0000)),
		new CInteriorDefinition("Mod Shop", "imp_dt1_11_modgarage", "", new Vector3(-73.9039, -821.6204, 284.0000)),
		new CInteriorDefinition("Executive Rich", "ex_sm_13_office_02b", "", new Vector3(-1579.756, -565.0661, 108.523)),
		new CInteriorDefinition("Executive Cool", "ex_sm_13_office_02c", "", new Vector3(-1579.678, -565.0034, 108.5229)),
		new CInteriorDefinition("Executive Contrast", "ex_sm_13_office_02a", "", new Vector3(-1579.583, -565.0399, 108.5229)),
		new CInteriorDefinition("Old Spice Warm", "ex_sm_13_office_01a", "", new Vector3(-1579.702, -565.0366, 108.5229)),
		new CInteriorDefinition("Old Spice Classical", "ex_sm_13_office_01b", "", new Vector3(-1579.643, -564.9685, 108.5229)),
		new CInteriorDefinition("Old Spice Vintage", "ex_sm_13_office_01c", "", new Vector3(-1579.681, -565.0003, 108.523)),
		new CInteriorDefinition("Power Broker Ice", "ex_sm_13_office_03a", "", new Vector3(-1579.677, -565.0689, 108.5229)),
		new CInteriorDefinition("Power Broker Conservative", "ex_sm_13_office_03b", "", new Vector3(-1579.708, -564.9634, 108.5229)),
		new CInteriorDefinition("Power Broker Polished", "ex_sm_13_office_03c", "", new Vector3(-1579.693, -564.8981, 108.5229)),
		new CInteriorDefinition("Garage 1", "imp_sm_13_cargarage_a", "", new Vector3(-1581.1120, -567.2450, 85.5000)),
		new CInteriorDefinition("Garage 2", "imp_sm_13_cargarage_b", "", new Vector3(-1568.7390, -562.0455, 85.5000)),
		new CInteriorDefinition("Garage 3", "imp_sm_13_cargarage_c", "", new Vector3(-1563.5570, -574.4314, 85.5000)),
		new CInteriorDefinition("Mod Shop", "imp_sm_13_modgarage", "", new Vector3(-1578.0230, -576.4251, 104.2000)),
		new CInteriorDefinition("Executive Rich", "ex_sm_15_office_02b", "", new Vector3(-1392.667, -480.4736, 72.04217)),
		new CInteriorDefinition("Executive Cool", "ex_sm_15_office_02c", "", new Vector3(-1392.542, -480.4011, 72.04211)),
		new CInteriorDefinition("Executive Contrast", "ex_sm_15_office_02a", "", new Vector3(-1392.626, -480.4856, 72.04212)),
		new CInteriorDefinition("Old Spice Warm", "ex_sm_15_office_01a", "", new Vector3(-1392.617, -480.6363, 72.04208)),
		new CInteriorDefinition("Old Spice Classical", "ex_sm_15_office_01b", "", new Vector3(-1392.532, -480.7649, 72.04207)),
		new CInteriorDefinition("Old Spice Vintage", "ex_sm_15_office_01c", "", new Vector3(-1392.611, -480.5562, 72.04214)),
		new CInteriorDefinition("Power Broker Ice", "ex_sm_15_office_03a", "", new Vector3(-1392.563, -480.549, 72.0421)),
		new CInteriorDefinition("Power Broker Conservative", "ex_sm_15_office_03b", "", new Vector3(-1392.528, -480.475, 72.04206)),
		new CInteriorDefinition("Power Broker Polished", "ex_sm_15_office_03c", "", new Vector3(-1392.416, -480.7485, 72.04207)),
		new CInteriorDefinition("Garage 1", "imp_sm_15_cargarage_a", "", new Vector3(-1388.8400, -478.7402, 56.1000)),
		new CInteriorDefinition("Garage 2", "imp_sm_15_cargarage_b", "", new Vector3(-1388.8600, -478.7574, 48.1000)),
		new CInteriorDefinition("Garage 3", "imp_sm_15_cargarage_c", "", new Vector3(-1374.6820, -474.3586, 56.1000)),
		new CInteriorDefinition("Mod Shop", "imp_sm_15_modgarage", "", new Vector3(-1391.2450, -473.9638, 77.2000)),
		new CInteriorDefinition("Clubhouse 1", "bkr_biker_interior_placement_interior_0_biker_dlc_int_01_milo", "", new Vector3(1107.04, -3157.399, -37.51859)),
		new CInteriorDefinition("Clubhouse 2", "bkr_biker_interior_placement_interior_1_biker_dlc_int_02_milo", "", new Vector3(998.4809, -3164.711, -38.90733)),
		new CInteriorDefinition("Warehouse 1 (Meth Lab)", "bkr_biker_interior_placement_interior_2_biker_dlc_int_ware01_milo", "", new Vector3(1009.5, -3196.6, -38.99682)),
		new CInteriorDefinition("Warehouse 2 (Weed Farm)", "bkr_biker_interior_placement_interior_3_biker_dlc_int_ware02_milo", "", new Vector3(1051.491, -3196.536, -39.14842)),
		new CInteriorDefinition("Warehouse 3 (Cocaine Lockup)", "bkr_biker_interior_placement_interior_4_biker_dlc_int_ware03_milo", "", new Vector3(1093.6, -3196.6, -38.99841)),
		new CInteriorDefinition("Warehouse 4 (Counterfeit Cash Factory)", "bkr_biker_interior_placement_interior_5_biker_dlc_int_ware04_milo", "", new Vector3(1121.897, -3195.338, -40.4025)),
		new CInteriorDefinition("Warehouse 5 (Document Forgery Office)", "bkr_biker_interior_placement_interior_6_biker_dlc_int_ware05_milo", "", new Vector3(1165, -3196.6, -39.01306)),
		new CInteriorDefinition("Warehouse Small", "ex_exec_warehouse_placement_interior_1_int_warehouse_s_dlc_milo", "", new Vector3(1094.988, -3101.776, -39.00363)),
		new CInteriorDefinition("Warehouse Medium", "ex_exec_warehouse_placement_interior_0_int_warehouse_m_dlc_milo", "", new Vector3(1056.486, -3105.724, -39.00439)),
		new CInteriorDefinition("Warehouse Large", "ex_exec_warehouse_placement_interior_2_int_warehouse_l_dlc_milo", "", new Vector3(1006.967, -3102.079, -39.0035)),
		new CInteriorDefinition("Vehicle Warehouse", "imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_", "", new Vector3(994.5925, -3002.594, -39.64699)),
		new CInteriorDefinition("Los Santos Customs", "ap1_04_interior_v_carmod_milo_", "", new Vector3(-337.2843, -137.6223, 39.00967)),
		new CInteriorDefinition("Normal Cargo Ship", "cargoship", "", new Vector3(-163.3628, -2385.161, 5.999994)),
		new CInteriorDefinition("Sunken Cargo Ship", "sunkcargoship", "", new Vector3(-163.3628, -2385.161, 5.999994)),
		new CInteriorDefinition("Burning Cargo Ship", "SUNK_SHIP_FIRE", "", new Vector3(-163.3628, -2385.161, 5.999994)),
		new CInteriorDefinition("Red Carpet", "redCarpet", "", new Vector3(300.5927, 300.5927, 104.3776)),
		new CInteriorDefinition("Rekt Stilthouse Destroyed", "DES_StiltHouse_imapend", "", new Vector3(-1020.518, 663.27, 153.5167)),
		new CInteriorDefinition("Rekt Stilthouse Rebuild", "DES_stilthouse_rebuild", "", new Vector3(-1020.518, 663.27, 153.5167)),
		new CInteriorDefinition("Union Depository", "FINBANK", "", new Vector3(2.6968, -667.0166, 16.13061)),
		new CInteriorDefinition("Trevors Trailer Dirty", "TrevorsMP", "", new Vector3(1975.552, 3820.538, 33.44833)),
		new CInteriorDefinition("Trevors Trailer Clean", "TrevorsTrailerTidy", "", new Vector3(1975.552, 3820.538, 33.44833)),
		new CInteriorDefinition("Stadium", "SP1_10_real_interior", "", new Vector3(-248.6731, -2010.603, 30.14562)),
		new CInteriorDefinition("Max Renda Shop", "refit_unload", "", new Vector3(-585.8247, -282.72, 35.45475)),
		new CInteriorDefinition("Jewel Store", "post_hiest_unload", "", new Vector3(-630.07, -236.332, 38.05704)),
		new CInteriorDefinition("FIB Lobby", "FIBlobby", "", new Vector3(110.4, -744.2, 45.7496)),
		new CInteriorDefinition("Lost MC Clubhouse", "bkr_bi_hw1_13_int", "", new Vector3(982.0083, -100.8747, 74.84512)),
		new CInteriorDefinition("gr_grdlc_yacht_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_grdlc_yacht_placement", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_bar", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_bar_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_bedrm", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_bedrm_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_bridge", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_bridge_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_enginrm", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_enginrm_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_lounge", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_lounge_lod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("gr_heist_yacht2_slod", "", "", new Vector3(-1363.724, 6734.108, 2.44598)),
		new CInteriorDefinition("smboat", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("smboat_lod", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_enginrm", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_Lounge", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_Bridge", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_Bar", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_Bedrm", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_DistantLights", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("hei_yacht_heist_LODLights", "", "", new Vector3(-2027.946, -1036.695, 6.707587)),
		new CInteriorDefinition("smboat", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("smboat_lod", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_enginrm", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_Lounge", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_Bridge", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_Bar", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_Bedrm", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_DistantLights", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_yacht_heist_LODLights", "", "", new Vector3(-2023.643, -1038.119, 5.576781)),
		new CInteriorDefinition("hei_carrier", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_carrier_DistantLights", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_Carrier_int1", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_Carrier_int2", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_Carrier_int3", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_Carrier_int4", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_Carrier_int5", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_Carrier_int6", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("hei_carrier_LODLights", "", "", new Vector3(3084.73, -4770.709, 15.26167)),
		new CInteriorDefinition("canyonriver01_traincrash", "", "", new Vector3(532.1309, 4526.187, 89.79387)),
		new CInteriorDefinition("railing_end", "", "", new Vector3(532.1309, 4526.187, 89.79387)),
		new CInteriorDefinition("canyonriver01", "", "", new Vector3(532.1309, 4526.187, 89.79387)),
		new CInteriorDefinition("railing_start", "", "", new Vector3(532.1309, 4526.187, 89.79387)),
		new CInteriorDefinition("prologue01", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01c", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01d", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01e", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01f", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01g", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01h", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01i", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01j", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01k", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue01z", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue02", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue03", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue03b", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue03_grv_dug", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue_grv_torch", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue04", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue04b", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue04_cover", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("des_protree_end", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("des_protree_start", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue05", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue05b", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue06", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue06b", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue06_int", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue06_pannel", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("plg_occl_00", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologue_occl", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologuerd", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("prologuerdb", "", "", new Vector3( 3217.697, -4834.826, 111.8152)),
		new CInteriorDefinition("farmint", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("farm_burnt", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("farm_burnt_props", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("des_farmhs_endimap", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("des_farmhs_end_occl", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("farm", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("farm_props", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("farm_int", "", "", new Vector3(2469.03, 4955.278, 45.11892)),
		new CInteriorDefinition("coronertrash", "", "", new Vector3(275.446, -1361.11, 24.5378)),
		new CInteriorDefinition("Coroner_Int_On", "", "", new Vector3(275.446, -1361.11, 24.5378)),
		new CInteriorDefinition("2 Car", "", "", new Vector3(173.2903, -1003.6, -99.65707)),
		new CInteriorDefinition("6 Car", "", "", new Vector3(197.8153, -1002.293, -99.65749)),
		new CInteriorDefinition("10 Car", "", "", new Vector3(229.9559, -981.7928, -99.66071)),
		new CInteriorDefinition("Low End Apartment", "", "", new Vector3(261.4586, -998.8196, -99.00863)),
		new CInteriorDefinition("Medium End Apartment", "", "", new Vector3(347.2686, -999.2955, -99.19622)),
		new CInteriorDefinition("4 Integrity Way, Apt 28", "", "", new Vector3(-18.07856, -583.6725, 79.46569)),
		new CInteriorDefinition("4 Integrity Way, Apt 30", "", "", new Vector3(-35.31277, -580.4199, 88.71221)),
		new CInteriorDefinition("Dell Perro Heights, Apt 4", "", "", new Vector3(-1468.14, -541.815, 73.4442)),
		new CInteriorDefinition("Dell Perro Heights, Apt 7", "", "", new Vector3(-1477.14, -538.7499, 55.5264)),
		new CInteriorDefinition("Richard Majestic, Apt 2", "", "", new Vector3(-915.811, -379.432, 113.6748)),
		new CInteriorDefinition("Tinsel Towers, Apt 42", "", "", new Vector3(-614.86, 40.6783, 97.60007)),
		new CInteriorDefinition("Eclipse Towers, Apt 3", "", "", new Vector3(-773.407, 341.766, 211.397)),
		new CInteriorDefinition("3655 Wild Oats Drive", "", "", new Vector3(-169.286, 486.4938, 137.4436)),
		new CInteriorDefinition("2044 North Conker Avenue", "", "", new Vector3(340.9412, 437.1798, 149.3925)),
		new CInteriorDefinition("2045 North Conker Avenue", "", "", new Vector3(373.023, 416.105, 145.7006)),
		new CInteriorDefinition("2862 Hillcrest Avenue", "", "", new Vector3(-676.127, 588.612, 145.1698)),
		new CInteriorDefinition("2868 Hillcrest Avenue", "", "", new Vector3(-763.107, 615.906, 144.1401)),
		new CInteriorDefinition("2874 Hillcrest Avenue", "", "", new Vector3(-857.798, 682.563, 152.6529)),
		new CInteriorDefinition("2677 Whispymound Drive", "", "", new Vector3(120.5, 549.952, 184.097)),
		new CInteriorDefinition("2133 Mad Wayne Thunder", "", "", new Vector3(-1288, 440.748, 97.69459)),
		new CInteriorDefinition("Bunker Interior", "", "", new Vector3(899.5518,-3246.038, -98.04907)),
		new CInteriorDefinition("CharCreator", "", "", new Vector3(402.5164, -1002.847, -99.2587)),
		new CInteriorDefinition("Mission Carpark", "", "", new Vector3(405.9228, -954.1149, -99.6627)),
		new CInteriorDefinition("Torture Room", "", "", new Vector3(136.5146, -2203.149, 7.30914)),
		new CInteriorDefinition("Solomon's Office", "", "", new Vector3(-1005.84, -478.92, 50.02733)),
		new CInteriorDefinition("Psychiatrist's Office", "", "", new Vector3(-1908.024, -573.4244, 19.09722)),
		new CInteriorDefinition("Omega's Garage", "", "", new Vector3(2331.344, 2574.073, 46.68137)),
		new CInteriorDefinition("Movie Theatre", "", "", new Vector3(-1427.299, -245.1012, 16.8039)),
		new CInteriorDefinition("Motel", "", "", new Vector3(152.2605, -1004.471, -98.99999)),
		new CInteriorDefinition("Madrazos Ranch", "", "", new Vector3(1399, 1150, 115)),
		new CInteriorDefinition("Life Invader Office", "", "", new Vector3(-1044.193, -236.9535, 37.96496)),
		new CInteriorDefinition("Lester's House", "", "", new Vector3(1273.9, -1719.305, 54.77141)),
		new CInteriorDefinition("FBI Top Floor", "", "", new Vector3(134.5835, -749.339, 258.152)),
		new CInteriorDefinition("FBI Floor 47", "", "", new Vector3(134.5835, -766.486, 234.152)),
		new CInteriorDefinition("FBI Floor 49", "", "", new Vector3(134.635, -765.831, 242.152)),
		new CInteriorDefinition("IAA Office", "", "", new Vector3(117.22, -620.938, 206.1398)),
		new CInteriorDefinition("Floyd's Apartment", "", "", new Vector3(-1150.703, -1520.713, 10.633)),
		new CInteriorDefinition("Tequi-la-la", "", "", new Vector3(-564.6385, 277.7336, 83.13632)),
		new CInteriorDefinition("Bahama Mamas West", "hei_sm_16_interior_v_bahama_milo_", "", new Vector3(-1387.384, -588.557, 30.31952)),
		new CInteriorDefinition("Split Sides West Comedy Club", "", "", new Vector3(382.6698, -1001.339, -99.00004)),
		new CInteriorDefinition("Smuggler's Run Hangar", "", "", new Vector3(-1266.802, -3014.837, -49.000)),
		new CInteriorDefinition("LTD (Grapeseed Main Street)", "", "", new Vector3(1698.376, 4929.637, 42.0781)),
		new CInteriorDefinition("LTD (Banham Canyon Drive)", "", "", new Vector3(-1821.921, 787.7424, 138.1834)),
		new CInteriorDefinition("LTD (West Mirror Drive)", "", "", new Vector3(1159.864, -327.3117, 69.21395)),
		new CInteriorDefinition("LTD (Ginger Street)", "", "", new Vector3(-711.7557, -917.2692, 19.2142)),
		new CInteriorDefinition("LTD (Grove Street)", "", "", new Vector3(-53.29216, -1757.069, 29.43966)),
		new CInteriorDefinition("24/7 (Senora Freeway)", "", "", new Vector3(1730.876, 6410.715, 35.00065)),
		new CInteriorDefinition("24/7 (Alhambra Drive)", "", "", new Vector3(1965.45, 3740.146, 32.32734)),
		new CInteriorDefinition("24/7 (Senora Freeway)", "", "", new Vector3(2682.5, 3282.227, 55.24056)),
		new CInteriorDefinition("24/7 (Route 68)", "", "", new Vector3(544.105, 2673.123, 42.15447)),
		new CInteriorDefinition("24/7 (Barbareno Road)", "", "", new Vector3(-3239.264, 1004.406, 12.45598)),
		new CInteriorDefinition("24/7 (Ineseno Road)", "", "", new Vector3(-3038.054, 589.7609, 7.816061)),
		new CInteriorDefinition("24/7 (Palomino Freeway)", "", "", new Vector3(2559.797, 385.3533, 108.6211)),
		new CInteriorDefinition("24/7 (Clinton Avenue)", "", "", new Vector3(376.5075, 322.8857, 103.5696)),
		new CInteriorDefinition("24/7 (Innocence Boulevard)", "", "", new Vector3(29.23317, -1349.951, 29.33034)),
		new CInteriorDefinition("Rob's Liquor (Great Ocean Highway)", "", "", new Vector3(-2974.149, 390.7819, 15.03373)),
		new CInteriorDefinition("Rob's Liquor (El Rancho Boulevard)", "", "", new Vector3(1141.874, -980.8714, 46.1998)),
		new CInteriorDefinition("Rob's Liquor (Prosperity Street)", "", "", new Vector3(-1491.382, -384.0144, 40.11004)),
		new CInteriorDefinition("Rob's Liquor (San Andreas Avenue)", "", "", new Vector3(-1226.786, -902.1702, 12.27802)),
		new CInteriorDefinition("Liquor Ace", "", "", new Vector3(1394.391, 3599.346, 35.00915)),
		new CInteriorDefinition("Scoops Liquor Barn", "", "", new Vector3(1166.538, 2703.077, 38.17911)),
		new CInteriorDefinition("DrJose Door Test Map", "", "testmap", new Vector3(-1083.674, -2942.086, 13.30734)),
		new CInteriorDefinition("Casino", "vw_casino_main﻿", "", new Vector3(1089.648f, 206.1842f, -48.99974f)),
		new CInteriorDefinition("Casino Garage", "vw_casino_garage", "", new Vector3(1295.000, 230.000, -50.000)),
		new CInteriorDefinition("Casino Car Park", "vw_casino_carpark", "", new Vector3(1380.000, 200.000, -50.000)),
		new CInteriorDefinition("Casino Penthouse", "vw_casino_penthouse", "", new Vector3(976.636, 70.295, 115.164)),
		new CInteriorDefinition("Urshankovs Fire Dept 1st Floor", "", "FIRE_STATION_1ST_FLOOR", new Vector3(-1434.91, -3163.29, 16.0)),
		new CInteriorDefinition("After Hours NightClub", "ba_int_placement_ba_interior_0_dlc_int_01_ba_milo_", "", new Vector3(-1604.664, -3012.583, -78.000)),
		new CInteriorDefinition("Complex Lobby", "", "ComplexLobby", new Vector3(-123.6693, -738.9312, 170.0)),
		new CInteriorDefinition("Hospital Hallway", "", "HospitalHallway", new Vector3(334.4048, -588.5160, 96.3179)),
		new CInteriorDefinition("Hospital Elevator Lobby", "", "HospitalElevatorLobby", new Vector3(314.5451, -560.9646, 96.0857)),
		new CInteriorDefinition("Hospital ER", "", "HospitalER", new Vector3(297.6188, -584.7103, 93.1076)),
		new CInteriorDefinition("Hospital XRay", "", "HospitalXRay", new Vector3(297.3681, -584.8237, 85.6175)),
		new CInteriorDefinition("Patient Room", "", "PatientRoom", new Vector3(348.7950, -581.8104, 75.2872)),
		new CInteriorDefinition("Yacht Interior", "sum_lost_yacht_int", "", new Vector3(3638.799, -4780.567, 5.500)),
		new CInteriorDefinition("Gym", "", "GymInterior", new Vector3(-1150.66f, 819.8044f, 173.9268f)),
		new CInteriorDefinition("Camper Interior", "", "CamperInterior", new Vector3(-996.598, -3415.391, 13.965)),
		new CInteriorDefinition("Small Bathroom", "", "SmallBathroom", new Vector3(994.5848, -131.4831, 95.9278)),
		new CInteriorDefinition("Small Warehouse", "", "SmallWarehouse", new Vector3(72.9816, 363.2352, -124.0473)),
		new CInteriorDefinition("Dive Bar", "", "DiveBarSmall", new Vector3(-1120.6165, -1333.7198, 13.0464)),
		new CInteriorDefinition("Snack Shack", "", "SnackShack", new Vector3(-952.0392, -2993.981, 0.5070)),
		new CInteriorDefinition("Gun Range", "", "RedsLSGC", new Vector3(-962.6287, -2985.086, -9.493095)),
		new CInteriorDefinition("Church", "", "Church", new Vector3(-1658.9857, -210.8112, 56.3504)),
		new CInteriorDefinition("Split Sides", "", "SplitSides", new Vector3(382.3779, -1000.9355, -99.96)),
		new CInteriorDefinition("Nightclub Bathroom", "", "NightclubBathroom", new Vector3(-1160.5391, -1254.6796, 14.6911)),
		new CInteriorDefinition("Island Vault", "", "", new Vector3(5012.0f, -5747.5f, 15.0f)),
		new CInteriorDefinition("Casino Nightclub", "", "", new Vector3(1550.0f, 250.0f, -48.0f)),
		new CInteriorDefinition("Submarine Interior", "", "", new Vector3(1561.562f, 410.45f, -48.0f)),
		new CInteriorDefinition("Vespucci Police Department", "", "VSPD", new Vector3(1542.3401f, 3206.9670f, 48.1977f)),

		//{ new CInteriorDefinition("Vespucci Apartment", "", "VespucciApt", new Vector3(-1346.2435, -1130.3658, 24.7182)) }, -- TODO_DANIELS: Requires quaternion fixes

	};
}