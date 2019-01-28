using MulaolaoBll . Dao;
using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;


namespace MulaolaoBll . Bll
{
    public class QuoBll
    {
        private readonly Dao.QuoDao dal=null;

        private readonly Dao.QUOADao dala=null;
        private readonly Dao.QUOBDao dalb=null;
        private readonly Dao.QUOCEDao dalc=null;
        private readonly Dao.QUODDao dald=null;
        private readonly QUOEDao dale=null;
        private readonly QUOFDao dalf=null;
        private readonly QUOGDao dalg=null;
        private readonly QUOHDao dalh=null;
        private readonly QUOIDao dali=null;
        private readonly QUOJDao dalj=null;
        private readonly QUOKDao dalk=null;
        private readonly QUOLDao dall=null;

        private readonly ChanPinZhiBaoBll dal195=null;
        private readonly SiReYiYincontractDao dal196=null;
        private readonly DuanLiaoDao dal505=null;

        public QuoBll ( )
        {
            dal = new Dao . QuoDao ( );
            dala = new Dao . QUOADao ( );
            dalb = new Dao . QUOBDao ( );
            dalc = new QUOCEDao ( );
            dald = new QUODDao ( );
            dale = new QUOEDao ( );
            dalf = new QUOFDao ( );
            dalg = new QUOGDao ( );
            dalh = new QUOHDao ( );
            dali = new QUOIDao ( );
            dalj = new QUOJDao ( );
            dalk = new QUOKDao ( );
            dall = new QUOLDao ( );

            dal195 = new ChanPinZhiBaoBll ( );
            dal196 = new SiReYiYincontractDao ( );
            dal505 = new DuanLiaoDao ( );
        }


        /// <summary>
        /// 获取509数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable getTableFor509To195 ( string num )
        {
            return dal195 . getTableFor509 ( num );
        }

        /// <summary>
        /// 195保存
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save195 ( MulaolaoLibrary . QUOAEntity model )
        {
            return dala . Save ( model );
        }

        /// <summary>
        /// 获取195数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOAEntity getModel195 ( int idx )
        {
            return dala . getModel ( idx );
        }

        /// <summary>
        /// 删除 195
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete195 ( int idx )
        {
            return dala . Delete ( idx );
        }

        /// <summary>
        /// 获取509数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable getTableFor509To196 ( string num )
        {
            return dal196 . getTableFor509 ( num );
        }

        /// <summary>
        /// 获取196数据列表
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOBEntity getModel196 ( int idx )
        {
            return dalb . getModel ( idx );
        }

        /// <summary>
        /// 删除196数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete196 ( int idx )
        {
            return dalb . Delete ( idx );
        }

        /// <summary>
        /// 保存196数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save196 ( MulaolaoLibrary.QUOBEntity model )
        {
            return dalb . Save ( model );
        }

        /// <summary>
        /// 保存338数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save338 ( MulaolaoLibrary . QUOCEntity model )
        {
            return dalc . Save ( model );
        }

        /// <summary>
        /// 获取338数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOCEntity getModel338 ( int idx )
        {
            return dalc . getModel ( idx );
        }

        /// <summary>
        /// 删除338数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete338 ( int idx )
        {
            return dalc . Delete ( idx );
        }

        /// <summary>
        /// 获取341 数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUODEntity getModel341 ( int idx )
        {
            return dald . getModel ( idx );
        }


        /// <summary>
        /// 保存341数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save341 ( MulaolaoLibrary . QUODEntity model )
        {
            return dald . Save ( model );
        }

        /// <summary>
        /// 删除341数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete341 ( int idx )
        {
            return dald . Delete ( idx );
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To341 ( string num )
        {
            return dald . getTableFor509 ( num );
        }

        /// <summary>
        /// 获取342数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOEEntity getModel342 ( int idx )
        {
            return dale . getModel ( idx );
        }

        /// <summary>
        /// 保存342数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save342 ( MulaolaoLibrary . QUOEEntity model )
        {
            return dale . Save ( model );
        }

        /// <summary>
        /// 删除342数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete342 ( int idx )
        {
            return dale . Delete ( idx );
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To342 ( string num )
        {
            return dale . getTableFor509 ( num );
        }

        /// <summary>
        /// 获取343数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOFEntity getModel343 ( int idx )
        {
            return dalf . getModel ( idx );
        }

        /// <summary>
        /// 保存343数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save343 ( MulaolaoLibrary . QUOFEntity model )
        {
            return dalf . Save ( model );
        }

        /// <summary>
        /// 删除343数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete343 ( int idx )
        {
            return dalf . Delete ( idx );
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To343 ( string num )
        {
            return dalf . getTableFor509 ( num );
        }


        /// <summary>
        /// 得到一个对象实体  347
        /// </summary>
        public MulaolaoLibrary . QUOGEntity getModel347 ( int idx )
        {
            return dalg . getModel ( idx );
        }


        /// <summary>
        /// 保存347数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save347 ( MulaolaoLibrary . QUOGEntity model )
        {
            return dalg . Save ( model );
        }

        /// <summary>
        /// 删除347数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete347 ( int idx )
        {
            return dalg . Delete ( idx );
        }


        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To347 ( string num )
        {
            return dalg . getTableFor509 ( num );
        }


        /// <summary>
        /// 获取一个实体  349
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOHEntity getModel349 ( int idx )
        {
            return dalh . getModel ( idx );
        }

        /// <summary>
        /// 保存349数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save349 ( MulaolaoLibrary . QUOHEntity model )
        {
            return dalh . Save ( model );
        }

        /// <summary>
        /// 删除349数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete349 ( int idx )
        {
            return dalh . Delete ( idx );
        }

        /// <summary>
        /// 获取349数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To349 ( string num )
        {
            return dalh . getTableFor509 ( num );
        }


        /// <summary>
        /// 获取339数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOIEntity getModel339 ( int idx )
        {
            return dali . GetModel ( idx );
        }


        /// <summary>
        /// 保存339数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save339 ( MulaolaoLibrary . QUOIEntity model )
        {
            return dali . Save ( model );
        }

        /// <summary>
        /// 删除339数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete339 ( int idx )
        {
            return dali . Delete ( idx );
        }


        /// <summary>
        /// 读取495数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor495 ( string num )
        {
            return dali . getTableFor495 ( num );
        }

        /// <summary>
        /// 获取344数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOJEntity getModel344 ( int idx )
        {
            return dalj . getModel ( idx );
        }


        /// <summary>
        /// 保存344数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save344 ( MulaolaoLibrary . QUOJEntity model )
        {
            return dalj . Save ( model );
        }


        /// <summary>
        /// 删除344数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete344 ( int idx )
        {
            return dalj . Delete ( idx );
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To344 ( string num )
        {
            return dalj . getTableFor509 ( num );
        }

        /// <summary>
        /// 获取505数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOKEntity getModel505 ( int idx )
        {
            return dalk . getModel ( idx );
        }

        /// <summary>
        /// 保存505数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save505 ( MulaolaoLibrary . QUOKEntity model )
        {
            return dalk . Save ( model );
        }

        /// <summary>
        /// 删除505一条数据
        /// </summary>
        public bool Delete505 ( int idx )
        {
            return dalk . Delete ( idx );
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509To505 ( string num )
        {
            return dal505 . getTable ( num );
        }

        /// <summary>
        /// 获取495数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOLEntity getModel495 ( int idx )
        {
            return dall . GetModel ( idx );
        }

        /// <summary>
        /// 保存数据  495
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save495 ( MulaolaoLibrary . QUOLEntity model )
        {
            return dall . Save ( model );
        }

        /// <summary>
        /// 删除一条数据 495
        /// </summary>
        public bool Delete495 ( int idx )
        {
            return dall . Delete ( idx );
        }

        /// <summary>
        /// 获取单号
        /// </summary>
        /// <returns></returns>
        public string getOddNum ( )
        {
            return dal . getOddNum ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableView ( string code )
        {
            return dal . getTableView ( code );
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool Delete ( string oddNum )
        {
            return dal . Delete ( oddNum );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="_quo"></param>
        /// <param name="table"></param>
        /// <param name="state"></param>
        /// <param name="idxList"></param>
        /// <returns></returns>
        public bool Save ( MulaolaoLibrary . QuoEntity _quo ,string state )
        {
            return dal . Save ( _quo ,state );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable getTableOnlyColumn ( )
        {
            return dal . getTableOnlyColumn ( );
        }

        /// <summary>
        /// 获取总数量
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int getCount ( string strWhere )
        {
            return dal . getCount ( strWhere );
        }

        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataTable getDataTableByChange ( string strWhere ,int startIndex ,int endIndex )
        {
            return dal . getDataTableByChange ( strWhere ,startIndex ,endIndex );
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QuoEntity getModel ( string strWhere )
        {
            return dal . getModel ( strWhere );
        }

        /// <summary>
        /// 获取业务人员
        /// </summary>
        /// <returns></returns>
        public DataTable getTableFor ( )
        {
            return dal . getTableFor ( );
        }

        }
}
