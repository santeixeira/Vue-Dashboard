<template>
  
  <div class="input-box">
    <i :class="icon"></i>
    <Multiselect
      :v-model="value"
      mode="tags"
      :placeholder="placeholder"
      :options="options"
      :searchable="true"
      :createTag="false"
    />
  </div>
</template>

<script lang="ts">
import { Skills } from "@/utils/index";
import Multiselect from "@vueform/multiselect";
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Tag",
  emits: ["addingTag"],
  components: { Multiselect },
  props: ["icon", "options", "placeholder"],
  data() {
    return {
      value: [],
    };
  },
  methods: {
    addTag(TagValue: string): void {
      this.$emit("addingTag", {
        descricao: TagValue,
      });
    },
  },
});
</script>
<style lang="scss">
@import url("@/assets/config_sass/tag.scss");
</style>
