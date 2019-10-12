using InFlightAppBACKEND.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data.Mappers
{
    public class PassengerConversationConfiguration : IEntityTypeConfiguration<PassengerConversation>
    {
        public void Configure(EntityTypeBuilder<PassengerConversation> builder)
        {
            builder.ToTable("PassengerConversation");
            builder.HasKey(pc => new { pc.PassengerId, pc.ConversationId });
            builder.HasOne(pc => pc.Passenger)
                .WithMany(p => p.PassengerConversations)
                .HasForeignKey(pc => pc.PassengerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(pc => pc.Conversation)
                .WithMany(c => c.PassengerConversations)
                .HasForeignKey(pc => pc.ConversationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
