using BlogApp.Application.Models.DTOs.MakaleDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Services.MakaleService
{
    public interface IMakaleService
    {
        Task<bool> EkleAsync(MakaleEkleDTO makaleEkleDTO);
        Task GuncelleAsync(MakaleGuncelleDTO makaleGuncelleDTO);
        Task<bool> SilAsync(int id);
        Task<IEnumerable<MakaleListeleDTO>> TumMakaleleriListeleAsync();           
        Task<MakaleListeleDTO> IdGoreMakaleleriListeleAsync(int id);
        Task<IEnumerable<MakaleListeleDTO>> UserGoreMakaleleriListeleAsync(string userID);     
        Task<IEnumerable<MakaleListeleDTO>> KonuGoreMakaleleriListeleAsync(int konuID);
    }
}
