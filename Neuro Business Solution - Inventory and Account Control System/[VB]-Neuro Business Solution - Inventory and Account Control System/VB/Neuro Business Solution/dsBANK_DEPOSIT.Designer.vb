﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("dsBANK_DEPOSIT"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class dsBANK_DEPOSIT
    Inherits System.Data.DataSet
    
    Private tableV_BANK_DEPOSITS As V_BANK_DEPOSITSDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("V_BANK_DEPOSITS")) Is Nothing) Then
                MyBase.Tables.Add(New V_BANK_DEPOSITSDataTable(ds.Tables("V_BANK_DEPOSITS")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property V_BANK_DEPOSITS() As V_BANK_DEPOSITSDataTable
        Get
            Return Me.tableV_BANK_DEPOSITS
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.BrowsableAttribute(true),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As dsBANK_DEPOSIT = CType(MyBase.Clone,dsBANK_DEPOSIT)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("V_BANK_DEPOSITS")) Is Nothing) Then
                MyBase.Tables.Add(New V_BANK_DEPOSITSDataTable(ds.Tables("V_BANK_DEPOSITS")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableV_BANK_DEPOSITS = CType(MyBase.Tables("V_BANK_DEPOSITS"),V_BANK_DEPOSITSDataTable)
        If (initTable = true) Then
            If (Not (Me.tableV_BANK_DEPOSITS) Is Nothing) Then
                Me.tableV_BANK_DEPOSITS.InitVars
            End If
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "dsBANK_DEPOSIT"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsBANK_DEPOSIT.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableV_BANK_DEPOSITS = New V_BANK_DEPOSITSDataTable
        MyBase.Tables.Add(Me.tableV_BANK_DEPOSITS)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeV_BANK_DEPOSITS() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
        Dim ds As dsBANK_DEPOSIT = New dsBANK_DEPOSIT
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function
    
    Public Delegate Sub V_BANK_DEPOSITSRowChangeEventHandler(ByVal sender As Object, ByVal e As V_BANK_DEPOSITSRowChangeEvent)
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     System.Serializable(),  _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class V_BANK_DEPOSITSDataTable
        Inherits System.Data.DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As System.Data.DataColumn
        
        Private columnBANK_ACC As System.Data.DataColumn
        
        Private columnSLIP_NO As System.Data.DataColumn
        
        Private columnDEPOSIT_AMT As System.Data.DataColumn
        
        Private columndDATE As System.Data.DataColumn
        
        Private columnsDESC As System.Data.DataColumn
        
        Private columnGROUP_NAME As System.Data.DataColumn
        
        Private columnUSER_NAME As System.Data.DataColumn
        
        Private columnGROUP_ID As System.Data.DataColumn
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "V_BANK_DEPOSITS"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property IDColumn() As System.Data.DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property BANK_ACCColumn() As System.Data.DataColumn
            Get
                Return Me.columnBANK_ACC
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property SLIP_NOColumn() As System.Data.DataColumn
            Get
                Return Me.columnSLIP_NO
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property DEPOSIT_AMTColumn() As System.Data.DataColumn
            Get
                Return Me.columnDEPOSIT_AMT
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property dDATEColumn() As System.Data.DataColumn
            Get
                Return Me.columndDATE
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property sDESCColumn() As System.Data.DataColumn
            Get
                Return Me.columnsDESC
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property GROUP_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnGROUP_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property USER_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnUSER_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property GROUP_IDColumn() As System.Data.DataColumn
            Get
                Return Me.columnGROUP_ID
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As V_BANK_DEPOSITSRow
            Get
                Return CType(Me.Rows(index),V_BANK_DEPOSITSRow)
            End Get
        End Property
        
        Public Event V_BANK_DEPOSITSRowChanging As V_BANK_DEPOSITSRowChangeEventHandler
        
        Public Event V_BANK_DEPOSITSRowChanged As V_BANK_DEPOSITSRowChangeEventHandler
        
        Public Event V_BANK_DEPOSITSRowDeleting As V_BANK_DEPOSITSRowChangeEventHandler
        
        Public Event V_BANK_DEPOSITSRowDeleted As V_BANK_DEPOSITSRowChangeEventHandler
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddV_BANK_DEPOSITSRow(ByVal row As V_BANK_DEPOSITSRow)
            Me.Rows.Add(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddV_BANK_DEPOSITSRow(ByVal BANK_ACC As String, ByVal SLIP_NO As String, ByVal DEPOSIT_AMT As Decimal, ByVal dDATE As Date, ByVal sDESC As String, ByVal GROUP_NAME As String, ByVal USER_NAME As String) As V_BANK_DEPOSITSRow
            Dim rowV_BANK_DEPOSITSRow As V_BANK_DEPOSITSRow = CType(Me.NewRow,V_BANK_DEPOSITSRow)
            rowV_BANK_DEPOSITSRow.ItemArray = New Object() {Nothing, BANK_ACC, SLIP_NO, DEPOSIT_AMT, dDATE, sDESC, GROUP_NAME, USER_NAME, Nothing}
            Me.Rows.Add(rowV_BANK_DEPOSITSRow)
            Return rowV_BANK_DEPOSITSRow
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As V_BANK_DEPOSITSDataTable = CType(MyBase.Clone,V_BANK_DEPOSITSDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New V_BANK_DEPOSITSDataTable
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnID = MyBase.Columns("ID")
            Me.columnBANK_ACC = MyBase.Columns("BANK_ACC")
            Me.columnSLIP_NO = MyBase.Columns("SLIP_NO")
            Me.columnDEPOSIT_AMT = MyBase.Columns("DEPOSIT_AMT")
            Me.columndDATE = MyBase.Columns("dDATE")
            Me.columnsDESC = MyBase.Columns("sDESC")
            Me.columnGROUP_NAME = MyBase.Columns("GROUP_NAME")
            Me.columnUSER_NAME = MyBase.Columns("USER_NAME")
            Me.columnGROUP_ID = MyBase.Columns("GROUP_ID")
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnID = New System.Data.DataColumn("ID", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnID)
            Me.columnBANK_ACC = New System.Data.DataColumn("BANK_ACC", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBANK_ACC)
            Me.columnSLIP_NO = New System.Data.DataColumn("SLIP_NO", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSLIP_NO)
            Me.columnDEPOSIT_AMT = New System.Data.DataColumn("DEPOSIT_AMT", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnDEPOSIT_AMT)
            Me.columndDATE = New System.Data.DataColumn("dDATE", GetType(Date), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndDATE)
            Me.columnsDESC = New System.Data.DataColumn("sDESC", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnsDESC)
            Me.columnGROUP_NAME = New System.Data.DataColumn("GROUP_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnGROUP_NAME)
            Me.columnUSER_NAME = New System.Data.DataColumn("USER_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnUSER_NAME)
            Me.columnGROUP_ID = New System.Data.DataColumn("GROUP_ID", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnGROUP_ID)
            Me.columnID.AutoIncrement = true
            Me.columnID.AllowDBNull = false
            Me.columnID.ReadOnly = true
            Me.columnBANK_ACC.AllowDBNull = false
            Me.columnBANK_ACC.MaxLength = 50
            Me.columnSLIP_NO.AllowDBNull = false
            Me.columnSLIP_NO.MaxLength = 50
            Me.columnDEPOSIT_AMT.ReadOnly = true
            Me.columndDATE.AllowDBNull = false
            Me.columnsDESC.MaxLength = 100
            Me.columnGROUP_NAME.MaxLength = 50
            Me.columnUSER_NAME.MaxLength = 50
            Me.columnGROUP_ID.AutoIncrement = true
            Me.columnGROUP_ID.AllowDBNull = false
            Me.columnGROUP_ID.ReadOnly = true
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewV_BANK_DEPOSITSRow() As V_BANK_DEPOSITSRow
            Return CType(Me.NewRow,V_BANK_DEPOSITSRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New V_BANK_DEPOSITSRow(builder)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(V_BANK_DEPOSITSRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.V_BANK_DEPOSITSRowChangedEvent) Is Nothing) Then
                RaiseEvent V_BANK_DEPOSITSRowChanged(Me, New V_BANK_DEPOSITSRowChangeEvent(CType(e.Row,V_BANK_DEPOSITSRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.V_BANK_DEPOSITSRowChangingEvent) Is Nothing) Then
                RaiseEvent V_BANK_DEPOSITSRowChanging(Me, New V_BANK_DEPOSITSRowChangeEvent(CType(e.Row,V_BANK_DEPOSITSRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.V_BANK_DEPOSITSRowDeletedEvent) Is Nothing) Then
                RaiseEvent V_BANK_DEPOSITSRowDeleted(Me, New V_BANK_DEPOSITSRowChangeEvent(CType(e.Row,V_BANK_DEPOSITSRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.V_BANK_DEPOSITSRowDeletingEvent) Is Nothing) Then
                RaiseEvent V_BANK_DEPOSITSRowDeleting(Me, New V_BANK_DEPOSITSRowChangeEvent(CType(e.Row,V_BANK_DEPOSITSRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveV_BANK_DEPOSITSRow(ByVal row As V_BANK_DEPOSITSRow)
            Me.Rows.Remove(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As dsBANK_DEPOSIT = New dsBANK_DEPOSIT
            xs.Add(ds.GetSchemaSerializable)
            Dim any1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "V_BANK_DEPOSITSDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class V_BANK_DEPOSITSRow
        Inherits System.Data.DataRow
        
        Private tableV_BANK_DEPOSITS As V_BANK_DEPOSITSDataTable
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableV_BANK_DEPOSITS = CType(Me.Table,V_BANK_DEPOSITSDataTable)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ID() As Decimal
            Get
                Return CType(Me(Me.tableV_BANK_DEPOSITS.IDColumn),Decimal)
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.IDColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BANK_ACC() As String
            Get
                Return CType(Me(Me.tableV_BANK_DEPOSITS.BANK_ACCColumn),String)
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.BANK_ACCColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property SLIP_NO() As String
            Get
                Return CType(Me(Me.tableV_BANK_DEPOSITS.SLIP_NOColumn),String)
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.SLIP_NOColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property DEPOSIT_AMT() As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableV_BANK_DEPOSITS.DEPOSIT_AMTColumn),Decimal)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'DEPOSIT_AMT' in table 'V_BANK_DEPOSITS' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.DEPOSIT_AMTColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property dDATE() As Date
            Get
                Return CType(Me(Me.tableV_BANK_DEPOSITS.dDATEColumn),Date)
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.dDATEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property sDESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BANK_DEPOSITS.sDESCColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'sDESC' in table 'V_BANK_DEPOSITS' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.sDESCColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property GROUP_NAME() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BANK_DEPOSITS.GROUP_NAMEColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'GROUP_NAME' in table 'V_BANK_DEPOSITS' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.GROUP_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property USER_NAME() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BANK_DEPOSITS.USER_NAMEColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'USER_NAME' in table 'V_BANK_DEPOSITS' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.USER_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property GROUP_ID() As Decimal
            Get
                Return CType(Me(Me.tableV_BANK_DEPOSITS.GROUP_IDColumn),Decimal)
            End Get
            Set
                Me(Me.tableV_BANK_DEPOSITS.GROUP_IDColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsDEPOSIT_AMTNull() As Boolean
            Return Me.IsNull(Me.tableV_BANK_DEPOSITS.DEPOSIT_AMTColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetDEPOSIT_AMTNull()
            Me(Me.tableV_BANK_DEPOSITS.DEPOSIT_AMTColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IssDESCNull() As Boolean
            Return Me.IsNull(Me.tableV_BANK_DEPOSITS.sDESCColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetsDESCNull()
            Me(Me.tableV_BANK_DEPOSITS.sDESCColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsGROUP_NAMENull() As Boolean
            Return Me.IsNull(Me.tableV_BANK_DEPOSITS.GROUP_NAMEColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetGROUP_NAMENull()
            Me(Me.tableV_BANK_DEPOSITS.GROUP_NAMEColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsUSER_NAMENull() As Boolean
            Return Me.IsNull(Me.tableV_BANK_DEPOSITS.USER_NAMEColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetUSER_NAMENull()
            Me(Me.tableV_BANK_DEPOSITS.USER_NAMEColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class V_BANK_DEPOSITSRowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As V_BANK_DEPOSITSRow
        
        Private eventAction As System.Data.DataRowAction
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As V_BANK_DEPOSITSRow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As V_BANK_DEPOSITSRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
