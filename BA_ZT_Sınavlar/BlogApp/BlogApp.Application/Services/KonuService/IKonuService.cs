using BlogApp.Application.Models.DTOs.KonuDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Services.KonuService
{
    public interface IKonuService
    {
        Task<bool> EkleAsync(KonuEkleDTO konuEkleDTO);
        Task GuncelleAsync(KonuGuncelleDTO konuGuncelleDTO);
        Task<bool> SilAsync(int id);
        Task<IEnumerable<KonuListeleDTO>> TumKonulariListeleAsync();
        Task<KonuListeleDTO> IdGoreKonulariListeleAsync(int id);
    }
}
