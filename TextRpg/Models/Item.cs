using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace TextRpg.Models
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _url;
        private int _health;
        private int _attackDamage;
        private int _intelligence;
        private int _luck;
        private int _charisma;
        private int _dexterity;
        private int _equippable;
        private string _action;

        public Item (string name, string imgUrl, int hp, int ad, int iq, int luck, int charisma, int dex, int equippable)
        {
            _name = name;
            _url = url;
            _health = hp;
            _attackDamage = ad;
            _intelligence = iq;
            _luck = luck;
            _charisma = charisma;
            _dexterity = dex;
            _equippable = equippable;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetImgUrl()
        {
            return _imgUrl;
        }
        public int GetHealth()
        {
            return _health;
        }
        public int GetAttackDamage()
        {
            return _attackDamage;
        }
        public int GetIntelligence()
        {
            return _intelligence;
        }
        public int GetLuck()
        {
            return _luck;
        }
        public int GetCharisma()
        {
            return _charisma;
        }
        public int GetDexterity()
        {
            return _dexterity;
        }
        public int GetEquippable()
        {
            return _equippable;
        }
    }
}
