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
 System.Xml.Serialization.XmlRootAttribute("dsLUP_BANK_NEW1"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class dsLUP_BANK_NEW1
    Inherits System.Data.DataSet
    
    Private tableV_LUP_BANK As V_LUP_BANKDataTable
    
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
            If (Not (ds.Tables("V_LUP_BANK")) Is Nothing) Then
                MyBase.Tables.Add(New V_LUP_BANKDataTable(ds.Tables("V_LUP_BANK")))
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
    Public ReadOnly Property V_LUP_BANK() As V_LUP_BANKDataTable
        Get
            Return Me.tableV_LUP_BANK
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
        Dim cln As dsLUP_BANK_NEW1 = CType(MyBase.Clone,dsLUP_BANK_NEW1)
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
            If (Not (ds.Tables("V_LUP_BANK")) Is Nothing) Then
                MyBase.Tables.Add(New V_LUP_BANKDataTable(ds.Tables("V_LUP_BANK")))
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
        Me.tableV_LUP_BANK = CType(MyBase.Tables("V_LUP_BANK"),V_LUP_BANKDataTable)
        If (initTable = true) Then
            If (Not (Me.tableV_LUP_BANK) Is Nothing) Then
                Me.tableV_LUP_BANK.InitVars
            End If
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "dsLUP_BANK_NEW1"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsLUP_BANK_NEW1.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableV_LUP_BANK = New V_LUP_BANKDataTable
        MyBase.Tables.Add(Me.tableV_LUP_BANK)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeV_LUP_BANK() As Boolean
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
        Dim ds As dsLUP_BANK_NEW1 = New dsLUP_BANK_NEW1
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function
    
    Public Delegate Sub V_LUP_BANKRowChangeEventHandler(ByVal sender As Object, ByVal e As V_LUP_BANKRowChangeEvent)
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     System.Serializable(),  _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class V_LUP_BANKDataTable
        Inherits System.Data.DataTable
        Implements System.Collections.IEnumerable
        
        Private columnBANK_ACC As System.Data.DataColumn
        
        Private columnBANK_NAME As System.Data.DataColumn
        
        Private columnBr_NAME As System.Data.DataColumn
        
        Private columnBr_CODE As System.Data.DataColumn
        
        Private columnADDRESS As System.Data.DataColumn
        
        Private columnCONTACT1 As System.Data.DataColumn
        
        Private columnCONTACT2 As System.Data.DataColumn
        
        Private columnMgr_NAME As System.Data.DataColumn
        
        Private columnMgr_PH As System.Data.DataColumn
        
        Private columnMgr_CELL As System.Data.DataColumn
        
        Private columnSTATUS As System.Data.DataColumn
        
        Private columnOPEN_BAL As System.Data.DataColumn
        
        Private columnBUSINESS_GROUP As System.Data.DataColumn
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "V_LUP_BANK"
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
        Public ReadOnly Property BANK_ACCColumn() As System.Data.DataColumn
            Get
                Return Me.columnBANK_ACC
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property BANK_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnBANK_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Br_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnBr_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Br_CODEColumn() As System.Data.DataColumn
            Get
                Return Me.columnBr_CODE
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property ADDRESSColumn() As System.Data.DataColumn
            Get
                Return Me.columnADDRESS
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property CONTACT1Column() As System.Data.DataColumn
            Get
                Return Me.columnCONTACT1
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property CONTACT2Column() As System.Data.DataColumn
            Get
                Return Me.columnCONTACT2
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Mgr_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnMgr_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Mgr_PHColumn() As System.Data.DataColumn
            Get
                Return Me.columnMgr_PH
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Mgr_CELLColumn() As System.Data.DataColumn
            Get
                Return Me.columnMgr_CELL
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property STATUSColumn() As System.Data.DataColumn
            Get
                Return Me.columnSTATUS
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property OPEN_BALColumn() As System.Data.DataColumn
            Get
                Return Me.columnOPEN_BAL
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property BUSINESS_GROUPColumn() As System.Data.DataColumn
            Get
                Return Me.columnBUSINESS_GROUP
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
        Public Default ReadOnly Property Item(ByVal index As Integer) As V_LUP_BANKRow
            Get
                Return CType(Me.Rows(index),V_LUP_BANKRow)
            End Get
        End Property
        
        Public Event V_LUP_BANKRowChanging As V_LUP_BANKRowChangeEventHandler
        
        Public Event V_LUP_BANKRowChanged As V_LUP_BANKRowChangeEventHandler
        
        Public Event V_LUP_BANKRowDeleting As V_LUP_BANKRowChangeEventHandler
        
        Public Event V_LUP_BANKRowDeleted As V_LUP_BANKRowChangeEventHandler
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddV_LUP_BANKRow(ByVal row As V_LUP_BANKRow)
            Me.Rows.Add(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddV_LUP_BANKRow(ByVal BANK_ACC As String, ByVal BANK_NAME As String, ByVal Br_NAME As String, ByVal Br_CODE As String, ByVal ADDRESS As String, ByVal CONTACT1 As String, ByVal CONTACT2 As String, ByVal Mgr_NAME As String, ByVal Mgr_PH As String, ByVal Mgr_CELL As String, ByVal STATUS As Boolean, ByVal OPEN_BAL As Decimal, ByVal BUSINESS_GROUP As String) As V_LUP_BANKRow
            Dim rowV_LUP_BANKRow As V_LUP_BANKRow = CType(Me.NewRow,V_LUP_BANKRow)
            rowV_LUP_BANKRow.ItemArray = New Object() {BANK_ACC, BANK_NAME, Br_NAME, Br_CODE, ADDRESS, CONTACT1, CONTACT2, Mgr_NAME, Mgr_PH, Mgr_CELL, STATUS, OPEN_BAL, BUSINESS_GROUP}
            Me.Rows.Add(rowV_LUP_BANKRow)
            Return rowV_LUP_BANKRow
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function FindByBANK_ACC(ByVal BANK_ACC As String) As V_LUP_BANKRow
            Return CType(Me.Rows.Find(New Object() {BANK_ACC}),V_LUP_BANKRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As V_LUP_BANKDataTable = CType(MyBase.Clone,V_LUP_BANKDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New V_LUP_BANKDataTable
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnBANK_ACC = MyBase.Columns("BANK_ACC")
            Me.columnBANK_NAME = MyBase.Columns("BANK_NAME")
            Me.columnBr_NAME = MyBase.Columns("Br_NAME")
            Me.columnBr_CODE = MyBase.Columns("Br_CODE")
            Me.columnADDRESS = MyBase.Columns("ADDRESS")
            Me.columnCONTACT1 = MyBase.Columns("CONTACT1")
            Me.columnCONTACT2 = MyBase.Columns("CONTACT2")
            Me.columnMgr_NAME = MyBase.Columns("Mgr_NAME")
            Me.columnMgr_PH = MyBase.Columns("Mgr_PH")
            Me.columnMgr_CELL = MyBase.Columns("Mgr_CELL")
            Me.columnSTATUS = MyBase.Columns("STATUS")
            Me.columnOPEN_BAL = MyBase.Columns("OPEN_BAL")
            Me.columnBUSINESS_GROUP = MyBase.Columns("BUSINESS_GROUP")
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnBANK_ACC = New System.Data.DataColumn("BANK_ACC", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBANK_ACC)
            Me.columnBANK_NAME = New System.Data.DataColumn("BANK_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBANK_NAME)
            Me.columnBr_NAME = New System.Data.DataColumn("Br_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBr_NAME)
            Me.columnBr_CODE = New System.Data.DataColumn("Br_CODE", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBr_CODE)
            Me.columnADDRESS = New System.Data.DataColumn("ADDRESS", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnADDRESS)
            Me.columnCONTACT1 = New System.Data.DataColumn("CONTACT1", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCONTACT1)
            Me.columnCONTACT2 = New System.Data.DataColumn("CONTACT2", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCONTACT2)
            Me.columnMgr_NAME = New System.Data.DataColumn("Mgr_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnMgr_NAME)
            Me.columnMgr_PH = New System.Data.DataColumn("Mgr_PH", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnMgr_PH)
            Me.columnMgr_CELL = New System.Data.DataColumn("Mgr_CELL", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnMgr_CELL)
            Me.columnSTATUS = New System.Data.DataColumn("STATUS", GetType(Boolean), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSTATUS)
            Me.columnOPEN_BAL = New System.Data.DataColumn("OPEN_BAL", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnOPEN_BAL)
            Me.columnBUSINESS_GROUP = New System.Data.DataColumn("BUSINESS_GROUP", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBUSINESS_GROUP)
            Me.Constraints.Add(New System.Data.UniqueConstraint("Constraint1", New System.Data.DataColumn() {Me.columnBANK_ACC}, true))
            Me.columnBANK_ACC.AllowDBNull = false
            Me.columnBANK_ACC.Unique = true
            Me.columnBANK_ACC.MaxLength = 50
            Me.columnBANK_NAME.AllowDBNull = false
            Me.columnBANK_NAME.MaxLength = 50
            Me.columnBr_NAME.AllowDBNull = false
            Me.columnBr_NAME.MaxLength = 100
            Me.columnBr_CODE.AllowDBNull = false
            Me.columnBr_CODE.MaxLength = 50
            Me.columnADDRESS.AllowDBNull = false
            Me.columnADDRESS.MaxLength = 200
            Me.columnCONTACT1.MaxLength = 50
            Me.columnCONTACT2.MaxLength = 50
            Me.columnMgr_NAME.MaxLength = 100
            Me.columnMgr_PH.MaxLength = 50
            Me.columnMgr_CELL.MaxLength = 50
            Me.columnSTATUS.AllowDBNull = false
            Me.columnOPEN_BAL.AllowDBNull = false
            Me.columnBUSINESS_GROUP.MaxLength = 50
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewV_LUP_BANKRow() As V_LUP_BANKRow
            Return CType(Me.NewRow,V_LUP_BANKRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New V_LUP_BANKRow(builder)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(V_LUP_BANKRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.V_LUP_BANKRowChangedEvent) Is Nothing) Then
                RaiseEvent V_LUP_BANKRowChanged(Me, New V_LUP_BANKRowChangeEvent(CType(e.Row,V_LUP_BANKRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.V_LUP_BANKRowChangingEvent) Is Nothing) Then
                RaiseEvent V_LUP_BANKRowChanging(Me, New V_LUP_BANKRowChangeEvent(CType(e.Row,V_LUP_BANKRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.V_LUP_BANKRowDeletedEvent) Is Nothing) Then
                RaiseEvent V_LUP_BANKRowDeleted(Me, New V_LUP_BANKRowChangeEvent(CType(e.Row,V_LUP_BANKRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.V_LUP_BANKRowDeletingEvent) Is Nothing) Then
                RaiseEvent V_LUP_BANKRowDeleting(Me, New V_LUP_BANKRowChangeEvent(CType(e.Row,V_LUP_BANKRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveV_LUP_BANKRow(ByVal row As V_LUP_BANKRow)
            Me.Rows.Remove(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As dsLUP_BANK_NEW1 = New dsLUP_BANK_NEW1
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
            attribute2.FixedValue = "V_LUP_BANKDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class V_LUP_BANKRow
        Inherits System.Data.DataRow
        
        Private tableV_LUP_BANK As V_LUP_BANKDataTable
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableV_LUP_BANK = CType(Me.Table,V_LUP_BANKDataTable)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BANK_ACC() As String
            Get
                Return CType(Me(Me.tableV_LUP_BANK.BANK_ACCColumn),String)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.BANK_ACCColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BANK_NAME() As String
            Get
                Return CType(Me(Me.tableV_LUP_BANK.BANK_NAMEColumn),String)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.BANK_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Br_NAME() As String
            Get
                Return CType(Me(Me.tableV_LUP_BANK.Br_NAMEColumn),String)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.Br_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Br_CODE() As String
            Get
                Return CType(Me(Me.tableV_LUP_BANK.Br_CODEColumn),String)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.Br_CODEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ADDRESS() As String
            Get
                Return CType(Me(Me.tableV_LUP_BANK.ADDRESSColumn),String)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.ADDRESSColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property CONTACT1() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_LUP_BANK.CONTACT1Column),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'CONTACT1' in table 'V_LUP_BANK' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_LUP_BANK.CONTACT1Column) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property CONTACT2() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_LUP_BANK.CONTACT2Column),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'CONTACT2' in table 'V_LUP_BANK' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_LUP_BANK.CONTACT2Column) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Mgr_NAME() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_LUP_BANK.Mgr_NAMEColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Mgr_NAME' in table 'V_LUP_BANK' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_LUP_BANK.Mgr_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Mgr_PH() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_LUP_BANK.Mgr_PHColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Mgr_PH' in table 'V_LUP_BANK' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_LUP_BANK.Mgr_PHColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Mgr_CELL() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_LUP_BANK.Mgr_CELLColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Mgr_CELL' in table 'V_LUP_BANK' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_LUP_BANK.Mgr_CELLColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property STATUS() As Boolean
            Get
                Return CType(Me(Me.tableV_LUP_BANK.STATUSColumn),Boolean)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.STATUSColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property OPEN_BAL() As Decimal
            Get
                Return CType(Me(Me.tableV_LUP_BANK.OPEN_BALColumn),Decimal)
            End Get
            Set
                Me(Me.tableV_LUP_BANK.OPEN_BALColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BUSINESS_GROUP() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_LUP_BANK.BUSINESS_GROUPColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'BUSINESS_GROUP' in table 'V_LUP_BANK' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_LUP_BANK.BUSINESS_GROUPColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsCONTACT1Null() As Boolean
            Return Me.IsNull(Me.tableV_LUP_BANK.CONTACT1Column)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetCONTACT1Null()
            Me(Me.tableV_LUP_BANK.CONTACT1Column) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsCONTACT2Null() As Boolean
            Return Me.IsNull(Me.tableV_LUP_BANK.CONTACT2Column)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetCONTACT2Null()
            Me(Me.tableV_LUP_BANK.CONTACT2Column) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsMgr_NAMENull() As Boolean
            Return Me.IsNull(Me.tableV_LUP_BANK.Mgr_NAMEColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetMgr_NAMENull()
            Me(Me.tableV_LUP_BANK.Mgr_NAMEColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsMgr_PHNull() As Boolean
            Return Me.IsNull(Me.tableV_LUP_BANK.Mgr_PHColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetMgr_PHNull()
            Me(Me.tableV_LUP_BANK.Mgr_PHColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsMgr_CELLNull() As Boolean
            Return Me.IsNull(Me.tableV_LUP_BANK.Mgr_CELLColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetMgr_CELLNull()
            Me(Me.tableV_LUP_BANK.Mgr_CELLColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsBUSINESS_GROUPNull() As Boolean
            Return Me.IsNull(Me.tableV_LUP_BANK.BUSINESS_GROUPColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetBUSINESS_GROUPNull()
            Me(Me.tableV_LUP_BANK.BUSINESS_GROUPColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class V_LUP_BANKRowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As V_LUP_BANKRow
        
        Private eventAction As System.Data.DataRowAction
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As V_LUP_BANKRow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As V_LUP_BANKRow
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
