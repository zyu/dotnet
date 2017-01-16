using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text; 

namespace testdb.Model
{
    
    public class Merchant 
    {
        public int Id{get;set;}
        /// <summary>
        /// 面积
        /// </summary>
        public short Area { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string Contacter { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string ContacterIdCard { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public SexType ContacterSex { get; set; }

        /// <summary>
        /// 业务经理编号
        /// </summary>
        public int SalerId { get; set; }

        /// <summary>
        /// 原业务经理编号
        /// </summary>
        public int OriginSalerId { get; set; }

        /// <summary>
        /// 抽奖次数
        /// </summary>
        public short LotteryNum { get; set; }


        /// <summary>
        /// 查询次数
        /// </summary>
        public int ChargeNum{ get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public Level Level { get; set; }


        /// <summary>
        /// 加款级别
        /// </summary>
        public decimal OrderLevel { get; set; }

        /// <summary>
        /// 日加款级别
        /// </summary>
        public decimal OrderLevelDay { get; set; }

        /// <summary>
        /// 是否漏单
        /// </summary>
        public bool IsMissed { get; set; }

        /// <summary>
        /// 移动折扣
        /// </summary>
        public decimal DiscountsByMobile { get; set; }

        /// <summary>
        /// 联通折扣
        /// </summary>
        public decimal DiscountsByUnicom { get; set; }

        /// <summary>
        /// 电信折扣
        /// </summary>
        public decimal DiscountsByT { get; set; }

        /// <summary>
        /// 游戏折扣
        /// </summary>
        public decimal DiscountsByGame { get; set; }

        /// <summary>
        /// QQ 折扣
        /// </summary>
        public decimal DiscountsByQQ { get; set; }

         

        /// <summary>
        /// 最后访问日期
        /// </summary>
        public DateTime LastVisitDate { get; set; }

        /// <summary>
        /// 区域名
        /// </summary>
        public string AreaName { get; set; }
        public string CouponCode { get; set; }
        /// <summary>
        /// 区域编号
        /// </summary>
        public short AreaNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Status Status { get; set; }
        private bool firstOrderCharge = true;
        /// <summary>
        /// 是否第一次订货充值
        /// </summary>
        public bool FirstOrderCharge
        {
            get
            {
                return firstOrderCharge;
            }
            set
            {
                firstOrderCharge = value;
            }
        }
        /// <summary>
        /// 协议上次统计时间,协议完成后更新
        /// </summary>
        public DateTime SignAgreementCountTime
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是加盟连锁店
        /// </summary>
        public bool IsVip
        {
            get;
            set;
        }
        /// <summary>
        /// 简称
        /// </summary>
        public string NickName
        {
            get;
            set;
        }
         public string HeadImg { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        public int RouteId { get; set; }
        /// <summary>
        /// 线路名称
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// 线路排序
        /// </summary>
        public int RouteOrderNum { get; set; }

        public int MerchantType { get; set; }

        /// <summary>
        /// 是否二批商
        /// </summary>
        public bool IsWholesale { get; set; }

        /// <summary>
        /// 折扣商 加款级别 或者是 结算款级别
        /// </summary>
        public int CutLevel { get; set; }
        public int FavourableType { get; set; }
        ///// <summary>
        ///// 渠道类型
        ///// </summary>
        //[CRL.Attribute.Field(FieldIndexType = CRL.Attribute.FieldIndexType.非聚集)]
        //public int Channel
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// 密码修改时间
        /// </summary>
        public DateTime PwdUpdateTime { get; set; }

        
        public string Mac { get; set; }
        /// <summary>
        /// 加盟商类型
        /// </summary>
        public StoreType StoreType { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WareHouseId { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WareHouseName { get; set; }
        /// <summary>
        /// 是否经过手机验证
        /// </summary>
        public bool IsVerify { get; set; }
      
        /// <summary>
        ///  经度
        /// </summary>
        public string Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }
        /// <summary>
        /// 兼职人员ID
        /// </summary>
        public int PartEmployeeId { get; set; }

        /// <summary>
        /// 是否认证
        /// </summary>
        public bool IsLicensed { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        public DateTime LicensedTime { get; set; }

        /// <summary>
        /// 是否需要令牌
        /// </summary>
        public bool IsToken { get; set; }

        /// <summary>
        /// 暂存修改商户登录手机号
        /// </summary>
        public string UpdateMobile { get; set; }

        /// <summary>
        /// 运营专员id
        /// </summary>
        public int SpecialEmployeeId { get; set; }

        

        /// <summary>
        /// 是否限制 限制的话订单不在后台显示 ，需采购发货后才能看到
        /// </summary>
        public bool IsLimit { get; set; }

        /// <summary>
        /// 托管店 额度(营业额可透支)
        /// </summary>
        public int StoreCredit { get; set; }


       
        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActivate { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        public DateTime ActivateTime { get; set; }
    }

    /// <summary>
    /// 加盟商级别
    /// </summary>
    public enum Level { 一级 = 1, 二级 = 2, 三级 = 3, 四级 = 4, 五级 = 5 ,其它=6}
    /// <summary>
    /// 加盟商联系人性别
    /// </summary>
    public enum SexType { 男 = 0, 女 = 1 }
    /// <summary>
    /// 加盟商状态
    /// </summary>
    public enum Status { 正常 = 0, 禁用 = 1, 冻结 = 2, 删除 = 3, 监管 = 4 }
    public enum MerchantType
    {
        正常 = 1,
        禁止话费充值 = 2
    }
    public enum StoreType
    {
        默认,
        连锁,
        新店,
        托管
    }
}
