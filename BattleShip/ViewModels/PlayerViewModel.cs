using BattleShip.Models;
using BattleShip.ViewModels.Base;
using BattleShip.Views.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BattleShip.ViewModels
{
    internal abstract class PlayerViewModel : BaseViewModel
    {
        /// <summary>
        /// Players ships in fleet
        /// </summary>
        public ObservableCollection<Ship> Ships { get; set; } = new ObservableCollection<Ship> { };

        /// <summary>
        /// Players battlefield(ocean)
        /// </summary>

        public ObservableCollection<OceanPiece>? Ocean { get; private set; }

        private const int _battleFieldSize = 10;

        public PlayerViewModel()
        {
            FillOcean();

        }

        private void FillOcean()
        {
            Ocean = new ObservableCollection<OceanPiece>();
            for (int x = 0; x < _battleFieldSize; x++)
            {
                for (int y = 0; y < _battleFieldSize; y++)
                {
                    var piece = new OceanPiece();
                    //piece.OceanColor = Brushes.Red;
                    Ocean.Add(piece);
                }
            }
        }
    }
}
