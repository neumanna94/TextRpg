using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TextRpg;
using System;

namespace TextRpg.Models
{
    public static class Game
    {
        private static GameUser _currentGameUser;
        private static Room _currentRoom;
        private static GameDisplay _gameDisplay;

        public void SetGameUser(GameUser myGameUser)
        {
            _currentGameUser = myGameUser;
        }

        public void SetCurrentRoom(int currentRoom)
        {
            _currentRoom = currentRoom;
        }

        public void SetGameDisplay(GameDisplay myGameDisplay)
        {
            _gameDisplay = myGameDisplay; 
        }
        public static GameUser GetGameUser()
        {
            return _currentUser;
        }
        public static Room GetRoom()
        {
            return _currentRoom;
        }
        public static GameDisplay GetGameDisplay()
        {
            return _gameDisplay;
        }

        public static void LetThereBeLight()
        {

        }

        public static void CheckEndGame()
        {

        }
        public static void Update()
        {

        }

        public static void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"UPDATE users SET room_number = @room_number, character_id = @character_id WHERE id = @id;";
            var roomPara = new MySqlParameter("@room_number", _currentRoom);
            var charIdPara = new MySqlParameter("@character_id", _currentUser.GetCharacter().GetId());
            var userIdPara = new MySqlParameter("@id", _currentUser.GetId());
            cmd.Parameters.Add(roomPara);
            cmd.Parameters.Add(charIdPara);
            cmd.Parameters.Add(userIdPara);
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }

        public static void Restart()
        {

        }

    }

}
