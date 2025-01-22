// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fases.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DatosDeConfiguracion.GrpcProtos {
  public static partial class Fase
  {
    static readonly string __ServiceName = "GrpcProtos.Fase";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest> __Marshaller_GrpcProtos_CreateFaseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatosDeConfiguracion.GrpcProtos.FaseDTO> __Marshaller_GrpcProtos_FaseDTO = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatosDeConfiguracion.GrpcProtos.FaseDTO.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatosDeConfiguracion.GrpcProtos.GetRequest> __Marshaller_GrpcProtos_GetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatosDeConfiguracion.GrpcProtos.GetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO> __Marshaller_GrpcProtos_NullableFaseDTO = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatosDeConfiguracion.GrpcProtos.Fases> __Marshaller_GrpcProtos_Fases = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatosDeConfiguracion.GrpcProtos.Fases.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatosDeConfiguracion.GrpcProtos.DeleteRequest> __Marshaller_GrpcProtos_DeleteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatosDeConfiguracion.GrpcProtos.DeleteRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest, global::DatosDeConfiguracion.GrpcProtos.FaseDTO> __Method_CreateFase = new grpc::Method<global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest, global::DatosDeConfiguracion.GrpcProtos.FaseDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateFase",
        __Marshaller_GrpcProtos_CreateFaseRequest,
        __Marshaller_GrpcProtos_FaseDTO);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatosDeConfiguracion.GrpcProtos.GetRequest, global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO> __Method_GetFase = new grpc::Method<global::DatosDeConfiguracion.GrpcProtos.GetRequest, global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFase",
        __Marshaller_GrpcProtos_GetRequest,
        __Marshaller_GrpcProtos_NullableFaseDTO);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::DatosDeConfiguracion.GrpcProtos.Fases> __Method_GetAllFases = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::DatosDeConfiguracion.GrpcProtos.Fases>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllFases",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_GrpcProtos_Fases);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatosDeConfiguracion.GrpcProtos.FaseDTO, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateFase = new grpc::Method<global::DatosDeConfiguracion.GrpcProtos.FaseDTO, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateFase",
        __Marshaller_GrpcProtos_FaseDTO,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatosDeConfiguracion.GrpcProtos.DeleteRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteFase = new grpc::Method<global::DatosDeConfiguracion.GrpcProtos.DeleteRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteFase",
        __Marshaller_GrpcProtos_DeleteRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DatosDeConfiguracion.GrpcProtos.FasesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Fase</summary>
    [grpc::BindServiceMethod(typeof(Fase), "BindService")]
    public abstract partial class FaseBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::DatosDeConfiguracion.GrpcProtos.FaseDTO> CreateFase(global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO> GetFase(global::DatosDeConfiguracion.GrpcProtos.GetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::DatosDeConfiguracion.GrpcProtos.Fases> GetAllFases(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateFase(global::DatosDeConfiguracion.GrpcProtos.FaseDTO request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteFase(global::DatosDeConfiguracion.GrpcProtos.DeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Fase</summary>
    public partial class FaseClient : grpc::ClientBase<FaseClient>
    {
      /// <summary>Creates a new client for Fase</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FaseClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Fase that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FaseClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FaseClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FaseClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatosDeConfiguracion.GrpcProtos.FaseDTO CreateFase(global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateFase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatosDeConfiguracion.GrpcProtos.FaseDTO CreateFase(global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatosDeConfiguracion.GrpcProtos.FaseDTO> CreateFaseAsync(global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateFaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatosDeConfiguracion.GrpcProtos.FaseDTO> CreateFaseAsync(global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO GetFase(global::DatosDeConfiguracion.GrpcProtos.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO GetFase(global::DatosDeConfiguracion.GrpcProtos.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO> GetFaseAsync(global::DatosDeConfiguracion.GrpcProtos.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO> GetFaseAsync(global::DatosDeConfiguracion.GrpcProtos.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatosDeConfiguracion.GrpcProtos.Fases GetAllFases(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllFases(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatosDeConfiguracion.GrpcProtos.Fases GetAllFases(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllFases, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatosDeConfiguracion.GrpcProtos.Fases> GetAllFasesAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllFasesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatosDeConfiguracion.GrpcProtos.Fases> GetAllFasesAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllFases, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateFase(global::DatosDeConfiguracion.GrpcProtos.FaseDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateFase(global::DatosDeConfiguracion.GrpcProtos.FaseDTO request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateFaseAsync(global::DatosDeConfiguracion.GrpcProtos.FaseDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateFaseAsync(global::DatosDeConfiguracion.GrpcProtos.FaseDTO request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteFase(global::DatosDeConfiguracion.GrpcProtos.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteFase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteFase(global::DatosDeConfiguracion.GrpcProtos.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteFase, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteFaseAsync(global::DatosDeConfiguracion.GrpcProtos.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteFaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteFaseAsync(global::DatosDeConfiguracion.GrpcProtos.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteFase, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FaseClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FaseClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FaseBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateFase, serviceImpl.CreateFase)
          .AddMethod(__Method_GetFase, serviceImpl.GetFase)
          .AddMethod(__Method_GetAllFases, serviceImpl.GetAllFases)
          .AddMethod(__Method_UpdateFase, serviceImpl.UpdateFase)
          .AddMethod(__Method_DeleteFase, serviceImpl.DeleteFase).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FaseBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateFase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DatosDeConfiguracion.GrpcProtos.CreateFaseRequest, global::DatosDeConfiguracion.GrpcProtos.FaseDTO>(serviceImpl.CreateFase));
      serviceBinder.AddMethod(__Method_GetFase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DatosDeConfiguracion.GrpcProtos.GetRequest, global::DatosDeConfiguracion.GrpcProtos.NullableFaseDTO>(serviceImpl.GetFase));
      serviceBinder.AddMethod(__Method_GetAllFases, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::DatosDeConfiguracion.GrpcProtos.Fases>(serviceImpl.GetAllFases));
      serviceBinder.AddMethod(__Method_UpdateFase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DatosDeConfiguracion.GrpcProtos.FaseDTO, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateFase));
      serviceBinder.AddMethod(__Method_DeleteFase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DatosDeConfiguracion.GrpcProtos.DeleteRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteFase));
    }

  }
}
#endregion
