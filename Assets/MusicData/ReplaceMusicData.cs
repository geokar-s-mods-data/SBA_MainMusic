using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace geokar {
	public class ReplaceMusicData : MonoBehaviour {
		// Название оригинальной милодии
		// The name of the original track
		public string original;
		// Название этой милодии в мод-меню на русском
		// The name of this track in the mod menu in Russian
		public string RU;
		// Название этой милодии в мод-меню на английском
		// The name of this track in the mod menu in English
		public string EN;
		
		// Специальные настройки. Вид: 
		//   настройка1:значение1`настройка2:значение2
		
		// Возможные настройки и их значаения:
		//   1. mission
		//      1) airplane (задание с самолётами)
		//      2) egg (задание - поиск яиц)
		//      3) electricity (задание - электричество)
		//      4) flooding (задание - затопление)
		//      5) lava (задание - пол это лава)
		//      6) parkour (задание - ПАРКУУУР)
		//      7) race (задание - гонка)
		//   2. cmp
		//      1) e (equal т. е. сравнить название; установлено по умолчанию без указания настройки)
		//      2) f (find т. е. искать в названии)
		//   3. add
		//      Имя мелодии которую нужно тоже заменить.
		//      Модом будет создана копия с теме же настройками только с целью указанной в данной настройке.
		
		// Special settings:
		// setting1:value1'setting2:value2
		
		// Possible settings and their meanings:
		//   1. mission
		//      1) airplane (mission with planes)
		//      2) egg (mission - egg search)
		//      3) electricity (mission - electricity)
		//      4) flooding (mission - flooding)
		//      5) lava (mission - the floor is lava)
		//      6) parkour (mission - parkour)
		//      7) race (mission - race)
		//   2. cmp
		//      1) e (equal i.e. compare the name; set by default without specifying the setting)
		//      2) f (find i.e. search in the name)
		//   3. add
		//      The name of the track that needs to be replaced too.
		//      The mod will create a copy with the same settings only for the purpose specified in this setting.
		public string apiCode;
	}
}