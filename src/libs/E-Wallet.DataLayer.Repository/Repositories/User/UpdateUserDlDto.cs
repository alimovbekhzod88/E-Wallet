﻿using Global.shared;

namespace E_Wallet.DataLayer.Repository
{
    public class UpdateUserDlDto : UserDlDto<UpdateUserDlDto>, IHaveIdProp<int>
    {
        [LocalizedRequired]
        [LocalizedRange(1, int.MaxValue)]
        public int Id { get; set; }
        [LocalizedRequired]
        [LocalizedRange(1, int.MaxValue)]
        public int StateId { get; set; }
    }
}
