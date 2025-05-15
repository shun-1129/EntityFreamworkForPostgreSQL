namespace DBEntity
{
    /// <summary>
    /// マスタデータストア
    /// </summary>
    public class MasterDataStore
    {
        /// <summary>
        /// マスタデータ
        /// </summary>
        private Dictionary<Type , object> _masterData = new Dictionary<Type, object> ();

        /// <summary>
        /// データセット
        /// </summary>
        /// <typeparam name="T">セットするデータクラス</typeparam>
        /// <param name="data">セットするデータ</param>
        public void Set<T> ( T data ) where T : notnull
        {
            _masterData[typeof ( T )] = data;
        }

        /// <summary>
        /// データ取得
        /// </summary>
        /// <typeparam name="T">取得するデータクラス</typeparam>
        /// <returns>データ</returns>
        public T Get<T> ()
        {
            if ( !_masterData.ContainsKey ( typeof ( T ) ) )
            {
                throw new InvalidOperationException ( $"型 {typeof ( T ).Name} のデータは存在しません。Set<T> で登録してください。" );
            }
            return ( T ) _masterData[typeof ( T )];
        }

        /// <summary>
        /// Keyが存在するか
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool ContainsKey ( Type type )
        {
            return _masterData.ContainsKey ( type );
        }
    }
}
