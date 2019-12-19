// /Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote.IService/INoteTypeRepository.cs
// 2019/12/19
// zhanghuqiang-zhq_092012@163.com
using System;using System.Collections.Generic;using System.Threading.Tasks;using NetNote.Models;namespace NetNote.IService{  public interface INoteTypeRepository  {
    Task<List<NoteType>> GetListAsync();  }}