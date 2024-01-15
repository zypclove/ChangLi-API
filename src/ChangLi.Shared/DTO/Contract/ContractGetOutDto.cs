﻿using ChangLi.Shared.Models;

namespace ChangLi.Shared.DTO.Contract;

/// <summary>
/// 合同
/// </summary>
public class ContractGetOutDto : DtoBase
{
    /// <summary>
    /// 标识
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// 合同类型
    /// </summary>
    public int ContractType { get; set; }
    /// <summary>
    /// 合同编号
    /// </summary>
    public string? ContractNumber { get; set; }
    /// <summary>
    /// 合同日期
    /// </summary>
    public System.DateTimeOffset ContractDate { get; set; }
    /// <summary>
    /// 合同标题
    /// </summary>
    public string ContractTitle { get; set; } = null!;
    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }
    /// <summary>
    /// 甲方
    /// </summary>
    public string PartyA { get; set; } = null!;
    /// <summary>
    /// 乙方
    /// </summary>
    public string PartyB { get; set; } = null!;
    /// <summary>
    /// 合同清单
    /// </summary>
    public IList<ContractItemModel> Items { get; set; } = new List<ContractItemModel>();
}

